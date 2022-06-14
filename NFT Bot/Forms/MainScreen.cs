using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFT_Bot {
    public partial class MainScreen : Form {
        const int MAX_NFTS_SHOWN = 500;
        const int MAX_PARALLELISM = 200;
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private BackgroundWorker bw1 = new BackgroundWorker();
        private List<NFT> nfts = new List<NFT>();
        private List<NFT> topNFTS = new List<NFT>();
        private static int tokenCounter = 1;

        public MainScreen() {
            InitializeComponent();
            Form.CheckForIllegalCrossThreadCalls = false;
            bw1.DoWork += new DoWorkEventHandler(bw1_DoWork);
            bw1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw1.WorkerSupportsCancellation = true;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            populateList();
            Console.WriteLine($"[{DateTime.Now}] Finished work.");
            cancellationTokenSource.Cancel();
            bw1.CancelAsync();
            btnFetch.Text = "Fetch";
        }

        private void fetchOSContent() {
            string query = "";
            int counter = 1;
            foreach (NFT nft in topNFTS) {
                query += $"token_ids={nft.Token_id}&";
                if ((counter % 30) == 0) {
                    OpenSea.RetrieveAssets(txtCollectionName.Text, query);
                    query = "";
                }
                counter++;
            }
            if(query != "") {
                OpenSea.RetrieveAssets(txtCollectionName.Text, query);
            }

            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = MAX_PARALLELISM;
            options.CancellationToken = cancellationTokenSource.Token;
            Parallel.ForEach(topNFTS, options, nft => {
                OpenSea.assignOSContent(nft);
            });
        }

        private void fetchApiContent(string apiUrl) {
            int lastID = (int)ncLastID.Value;
            if (apiUrl.Contains("ipfs")) {
                //apiUrl = apiUrl.Replace(".*ipfs", "http://127.0.0.1:8080/ipfs/");
                apiUrl = Regex.Replace(apiUrl, ".*ipfs.*?/", "http://127.0.0.1:8080/ipfs/");
            }
            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = MAX_PARALLELISM;
            options.CancellationToken = cancellationTokenSource.Token;
            try {
                Parallel.For(1, (int)ncLastID.Value, options, i => {
                    NFT collectionNFT = Sniper.getNFT(apiUrl, i.ToString());
                    Interlocked.Increment(ref tokenCounter);
                    lblProgress2.Invoke((MethodInvoker)(() => lblProgress2.Text = $"Current Api Token : {tokenCounter} / {lastID}"));
                    nfts.Add(collectionNFT);
                });
            } catch (OperationCanceledException) {
                Console.WriteLine($"[{DateTime.Now}] Stopped.");
            }
        }

        private void bw1_DoWork(object sender, DoWorkEventArgs e) {
            string oldEtherscanUrl = Etherscan.getApiUrl(txtApi.Text);
            string newEtherscanUrl = oldEtherscanUrl;

            if (rbTrigger.Checked) {
                string oldApiContent = Sniper.getApiContent(newEtherscanUrl + "15");
                do {
                    newEtherscanUrl = Etherscan.getApiUrl(txtApi.Text);
                    string newApiContent = Sniper.getApiContent(newEtherscanUrl + "15");
                    if(oldEtherscanUrl == newEtherscanUrl && newApiContent.Contains("attributes")) {
                        if(oldApiContent != newApiContent) {
                            break;
                        }
                    }
                    Thread.Sleep(700);
                    Console.WriteLine($"[{ DateTime.Now}]" + " Waiting for url to change..." + "current url is : " + newEtherscanUrl);
                } while (oldEtherscanUrl == newEtherscanUrl);
            }


            Console.WriteLine($"[{DateTime.Now}] Starting work.");

            fetchApiContent(newEtherscanUrl);
            assignRanks();
            fetchOSContent();

        }

        private void btnFetch_Click(object sender, EventArgs e) {
            if (txtApi.Text != "" && txtApi.Text != null && txtCollectionName.Text != "" && txtCollectionName.Text != null) {
                if (!bw1.IsBusy) {
                    clearLists();
                    bw1.RunWorkerAsync();
                    btnFetch.Text = "Stop";
                } else {
                    cancellationTokenSource.Cancel();
                    bw1.CancelAsync();
                    btnFetch.Text = "Fetch";
                }
            } else {
                MessageBox.Show("API Url/Collection name is missing!");
            }
        }

        private void rbShowListedOnly_CheckedChanged(object sender, EventArgs e) {
            populateList();
        }

        private void rbShowAll_CheckedChanged(object sender, EventArgs e) {
            populateList();
        }

        private void rbSortPrice_CheckedChanged(object sender, EventArgs e) {
            populateList();
        }
        private void rbSortRank_CheckedChanged(object sender, EventArgs e) {
            populateList();
        }

        /**
         * 
         * Assigns the calculated rank 
         * to each NFT using the Dictionary
         * 
         */
        private void assignRanks() {
            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = MAX_PARALLELISM;
            Parallel.ForEach(nfts, options, i => {
                if (i != null) {
                    i.calculateRarity();
                }
            });
            nfts = nfts.Where(o => o != null).OrderByDescending(o => o.Probability).ToList();
            for (int i = 0; i < MAX_NFTS_SHOWN; i++) {
                if(nfts.Count > i) {
                    topNFTS.Add(nfts[i]);
                    topNFTS[i].Rank = (i + 1);
                } else {
                    break;
                }
            }
        }


        /**
         * 
         * Clears the NFT Items list
         * Populates the list depending on 
         * the chosen Filters
         * 
         **/
        private void populateList() {
            nftsList.Controls.Clear();
            List<NFT> filteredNFTs = new List<NFT>();
            OpenSea.clearAssets();

            if (rbSortPrice.Checked) {
                filteredNFTs = topNFTS.Where(o => o != null).Where(o => o.Price != 0).OrderBy(o => o.Price).ToList();
            } else if (rbSortRank.Checked) {
                filteredNFTs = topNFTS.Where(o => o != null).OrderBy(o => o.Rank).ToList();
            }
            if (rbShowListedOnly.Checked) {
                filteredNFTs = filteredNFTs.Where(o => o != null).Where(o => o.ForSale == true).ToList();
            }
            int counter = 0;
            foreach (NFT nft in filteredNFTs) {
                if (counter < MAX_NFTS_SHOWN) {
                    if (rbShowListedOnly.Checked) {
                        if (nft.ForSale) {
                            NFT_ITEM nftItem = new NFT_ITEM(nft, rbShowImage.Checked);
                            nftsList.Controls.Add(nftItem);
                        }
                    } else if (rbShowAll.Checked) {
                        NFT_ITEM nftItem = new NFT_ITEM(nft, rbShowImage.Checked);
                        nftsList.Controls.Add(nftItem);
                    }
                    counter++;
                } else {
                    break;
                }
            }
        }

        /**
         * 
         * Used to clear all lists
         * so the Sniper can start a new 
         * fetching session
         * 
         */
        private void clearLists() {
            nftsList.Controls.Clear();
            cancellationTokenSource.Dispose();
            cancellationTokenSource = new CancellationTokenSource();
            nfts.Clear();
            Dictionary.clearDict();
            tokenCounter = 1;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK) {
                using(System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName)) {
                    /*
                    foreach(NFT nft in nfts) {
                        sw.WriteLine($"Rank # {nft.Rank} | Token ID : {nft.Token_id}");
                    }
                    */

                    Console.WriteLine($"Items Amount : {Dictionary.getMaxTraits()}");

                    sw.WriteLine("\n-----------------------------------------------\n");

                    foreach (string item in Dictionary.getDictionary()) {
                        sw.WriteLine(item);
                    }

                    sw.WriteLine("\n-----------------------------------------------\n");

                    for(int i = 0; i < nfts.Count; i++) {
                        sw.WriteLine($"Rank # {i + 1} | Token ID : {nfts[i].Token_id}");
                    }
                }
                MessageBox.Show("Ranks have been saved.");
            }
        }
    }
}
