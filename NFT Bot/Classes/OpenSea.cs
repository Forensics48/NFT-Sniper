using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NFT_Bot {
    class OpenSea {
        private static List<OpenSeaItem> os_items = new List<OpenSeaItem>();
        /**
         * 
         * Retrieves an asset from OpenSea
         * 
         */
        public static void RetrieveAssets(string collectionName, string tokens_id) {
            string url = $"https://api.opensea.io/api/v1/assets?{tokens_id}order_direction=desc&offset=0&limit=30&collection={collectionName}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            var content = string.Empty;
            using (var response = (HttpWebResponse)request.GetResponse()) {
                using (var stream = response.GetResponseStream()) {
                    using (var sr = new StreamReader(stream)) {
                        content = sr.ReadToEnd();
                    }
                }
            }
            using JsonDocument doc = JsonDocument.Parse(content);
            JsonElement root = doc.RootElement;
            JsonElement assets = root.GetProperty("assets");
            var items = assets.EnumerateArray();
            while (items.MoveNext()) {
                var item = items.Current;
                OpenSeaItem osItem = new OpenSeaItem();
                osItem.OpenseaLink = assignLink(item.ToString());
                osItem.Token_id = assignToken(item.ToString());
                osItem.isForSale = isForSale(item.ToString());
                if(osItem.isForSale) {
                    osItem.Price = assignPrice(item.ToString());
                }
                os_items.Add(osItem);
            }
        }

        public static string assignLink(string assetJson) {
            using JsonDocument doc = JsonDocument.Parse(assetJson);
            JsonElement root = doc.RootElement;
            JsonElement link = root.GetProperty("permalink");
            return link.GetString();
        }

        public static string assignToken(string assetJson) {
            using JsonDocument doc = JsonDocument.Parse(assetJson);
            JsonElement root = doc.RootElement;
            JsonElement tokenId = root.GetProperty("token_id");
            return tokenId.GetString();
        }

        public static bool isForSale(string assetJson) {
            using JsonDocument doc = JsonDocument.Parse(assetJson);
            JsonElement root = doc.RootElement;
            JsonElement isForSale = root.GetProperty("sell_orders");
            if(isForSale.ToString() != "") {
                return true;
            } else {
                return false;
            }
        }

        public static double assignPrice(string assetJson) {
            using JsonDocument doc = JsonDocument.Parse(assetJson);
            JsonElement root = doc.RootElement;
            JsonElement openOrders = root.GetProperty("sell_orders");
            var ordersArray = openOrders.EnumerateArray();
            var firstOrder = ordersArray.First();
            double price = double.Parse(firstOrder.GetProperty("current_price").GetString()) * 0.000000000000000001;
            return Math.Round(price, 2);
        }

        public static void assignOSContent(NFT nft) {
            OpenSeaItem osCorrespondingItem = os_items.Find(x => x.Token_id == nft.Token_id);
            nft.Price = osCorrespondingItem.Price;
            nft.OpenseaLink = osCorrespondingItem.OpenseaLink;
            nft.ForSale = osCorrespondingItem.isForSale;
        }

        public static void clearAssets() {
            os_items.Clear();
        }
    }
}
