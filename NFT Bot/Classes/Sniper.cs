using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NFT_Bot {
    class Sniper {

        /**
         * 
         * Retrieves the Api Content for a given NFT
         * Retrieves the OpenSea Content for a given NFT
         * Creates an NFT and passes the API and OS Content
         *  
         **/
        public static NFT getNFT(string apiUrl, string currentID) {
            string apiContent = getApiContent(apiUrl + currentID);
            NFT fetchedNFT = new NFT(currentID, apiContent);
            return fetchedNFT;
        }

        /**
         * 
         * Returns the Api Content for a NFT
         * 
         **/
        public static string getApiContent(string fullUrl) {
            var request = (HttpWebRequest)WebRequest.Create(fullUrl);
            request.Method = "GET";
            request.AllowAutoRedirect = true;
            request.Timeout = 8000;
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            var content = string.Empty;
            try {
                using (var response = (HttpWebResponse)request.GetResponse()) {
                    using (var stream = response.GetResponseStream()) {
                        using (var sr = new StreamReader(stream)) {
                            content = sr.ReadToEnd();
                        }
                    }
                }
            } catch (WebException ex) {
                if (ex.Status == WebExceptionStatus.ProtocolError &&
    ex.Response != null) {
                    var resp = (HttpWebResponse)ex.Response;
                    if (resp.StatusCode == HttpStatusCode.NotFound) {
                        Console.WriteLine(fullUrl + " couldn't be found.");
                    }
                } else {
                    getApiContent(fullUrl);
                    Console.WriteLine("Retrying : " + fullUrl);
                }
            }
            return content;
        }

    }
}
