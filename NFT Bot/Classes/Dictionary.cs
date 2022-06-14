using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFT_Bot {
    class Dictionary {
        private static int maxTraits = 0;
        private static ConcurrentDictionary<Tuple<string, string>, int> dict = new ConcurrentDictionary<Tuple<string, string>, int>();

        /**
         * 
         * Adds a word to the dictionary 
         * and increases the amount of maximum  
         * traits in the dictionary
         * 
         **/
        public static void addWord(Tuple<string, string> pair) {
            if (!dict.ContainsKey(pair)) {
                dict.TryAdd(pair, 0);
            } else {
                dict[pair] += 1;
            }
            maxTraits++;
        }

        /**
         * 
         * Returns the Rarity for a certain trait
         * 
         **/
        public static float getRarity(Tuple<string, string> pair) {
            /*
            if(dict.ContainsKey(pair)) {
                float rarity = maxTraits / (float)dict[pair] ;
                return rarity;
            } else {
                return 0;
            }
            */
            if (dict.ContainsKey(pair)) {
                float rarity = 1 / ((float)dict[pair] / calcTraitAmount(pair));
                return rarity;
            } else {
                return 0;
            }
        }

        public static void calcMaxNfts() {
            foreach(var item in dict) {
                maxTraits += item.Value;
            }
        }

        public static int calcTraitAmount(Tuple<string, string> pair) {
            int itemAmount = 0;
            foreach(var item in dict) {
                if(item.Key.Item1 == pair.Item1) {
                    itemAmount += item.Value;
                }
            }
            return itemAmount;
        }

        public static void clearDict() {
            dict.Clear();
        }

        public static List<string> getDictionary() {
            List<string> dictonaryItems = new List<string>();
            foreach(KeyValuePair<Tuple<string, string>, int> pair in dict) {
                string item = pair.Key + " : " + pair.Value;
                dictonaryItems.Add(item);
            }

            return dictonaryItems;
        }

        public static int getMaxTraits() {
            return maxTraits;
        }
    }
}
