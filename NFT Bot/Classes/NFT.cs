using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NFT_Bot {
    public class NFT {

        List<Tuple<string, string>> words = new List<Tuple<string, string>>();
        public NFT(string tokenID, string apiContent) {
            Token_id = tokenID;
            ApiContent = apiContent;
            filterWords();
        }

        public string Token_id { get; set; }

        public int Rank { get; set; }

        public bool ForSale { get; set; }

        public string ApiContent { get; set; }

        public string OpenseaContent { get; set; }

        public double Price { get; set; }

        public string OpenseaLink { get; set; }

        public float Probability { get; set; }

        /**
         * 
         * Filters the NFT Image Url
         * from the Api Content
         * 
         **/
        /*
        private string getImageUrl() {
            string pattern = ".*\"image\":\\s?\"(.*?)\"";
            Regex rg = new Regex(pattern);
            MatchCollection matches = rg.Matches(ApiContent);
            if(matches.Count > 0) {
                if (matches[0].Groups[1].Value != "" && matches[0].Groups[1] != null) {
                    string url = matches[0].Groups[1].Value;
                    if (url.Contains("ipfs")) {
                        url = url.Replace("ipfs://", "http://127.0.0.1:8080/ipfs/");
                    }
                    return url;
                }
            }
            return "Error getting image";
        }
        */

        public void calculateRarity() {
            float probability = 0;
            foreach(Tuple<string, string> pair in words) {
                probability += Dictionary.getRarity(pair);
            }
            Probability = probability;
        }

        /**
         * 
         * Filters the trait words from the Api content
         * 
         */
        private void filterWords() {
            if(ApiContent != "") {
                using JsonDocument doc = JsonDocument.Parse(ApiContent);
                JsonElement root = doc.RootElement;
                JsonElement attributes = new JsonElement();
                bool noAttributes = false;
                try {
                    attributes = root.GetProperty("attributes");
                } catch {
                    noAttributes = true;
                }

                if(!noAttributes) {
                    var traits = attributes.EnumerateArray();
                    while (traits.MoveNext()) {
                        var trait = traits.Current;

                        var props = trait.EnumerateObject();
                        string[] nftTraits = new string[2];
                        int counter = 0;

                        while (props.MoveNext()) {
                            var prop = props.Current;
                            if (counter == 0) {
                                nftTraits[0] = prop.Value.ToString();
                                counter = 1;
                            } else if (counter == 1) {
                                nftTraits[1] = prop.Value.ToString();
                                counter = 0;
                            }
                        }
                        Tuple<string, string> nftTrait = Tuple.Create(nftTraits[0], nftTraits[1]);
                        Dictionary.addWord(nftTrait);
                        words.Add(nftTrait);
                    }

                }
            } else {
                Console.WriteLine("Api Content was empty");
            }

        }

        public int getWordsCount() {
            return words.Count;
        }
    }
}
