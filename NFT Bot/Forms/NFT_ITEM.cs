using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFT_Bot {
    public partial class NFT_ITEM : UserControl {
        private NFT itemNFT;

        public NFT_ITEM() {
            InitializeComponent();
        }

        public NFT_ITEM(NFT item, bool loadImage) {
            itemNFT = item;
            InitializeComponent();
            string[] row = new string[] { item.Rank.ToString(), item.Token_id, item.ForSale.ToString(), item.Price.ToString() };
            dataGridView1.Rows.Add(row);
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0) {
                MessageBox.Show("Test");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(itemNFT.OpenseaLink);
        }

        private void NFT_ITEM_DoubleClick(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(itemNFT.OpenseaLink);
        }
    }
}
