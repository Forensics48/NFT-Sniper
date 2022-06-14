using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFT_Bot {
    class OpenSeaItem {
        public string Token_id { get; set; }

        public string OpenseaContent { get; set; }

        public double Price { get; set; }

        public string OpenseaLink { get; set; }

        public bool isForSale { get; set; }
    }
}
