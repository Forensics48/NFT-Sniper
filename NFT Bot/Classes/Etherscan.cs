using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFT_Bot {
    class Etherscan {

        /**
         * 
         * Retrieves the Api Url from Etherscan
         * 
         */
        public static string getApiUrl(string address) {

            var request = (HttpWebRequest)WebRequest.Create("https://node1.web3api.com/");

            var postData = "{\"jsonrpc\":\"2.0\",\"id\":16,\"method\":\"eth_call\",\"params\":[{\"from\":\"0x0000000000000000000000000000000000000000\",\"data\":\"0xc87b56dd000000000000000000000000000000000000000000000000000000000000000f\",\"to\":\"" + address + "\"},\"latest\"]}";
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "*/*";
            request.Host = "node1.web3api.com";
            request.Referer = "https://etherscan.io/";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:92.0) Gecko/20100101 Firefox/92.0";
            request.AllowAutoRedirect = true;
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream()) {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            responseString = filterResult(responseString);
            responseString = filterString(responseString);
            responseString = FromHex(responseString);
            responseString = clearString(responseString);
            return responseString;
        }

        private static string filterString(string toFilter) {
            string pattern = "0x0+20{63}(.*)";
            Regex rg = new Regex(pattern);
            MatchCollection matches = rg.Matches(toFilter);
            if (matches.Count > 0) {
                return matches[0].Groups[1].Value;
            }
            return "";
        }

        private static string filterResult(string toFilter) {
            string pattern = ".*\"result\":\"(.*)\"}";
            Regex rg = new Regex(pattern);
            MatchCollection matches = rg.Matches(toFilter);
            if (matches.Count > 0) {
                return matches[0].Groups[1].Value;
            }
            return "";
        }

        private static string FromHex(string hex) {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++) {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            byte[] data = raw;
            string url = Encoding.ASCII.GetString(data);
            url = url.Remove(0, 1);
            url = url.TrimEnd();
            return url;
        }

        private static string clearString(string toClear) {
            string pattern = "(.*)/15.*";
            Regex rg = new Regex(pattern);
            MatchCollection matches = rg.Matches(toClear);
            if (matches.Count > 0) {
                return matches[0].Groups[1].Value + "/";
            }
            return "";
        }
    }
}
