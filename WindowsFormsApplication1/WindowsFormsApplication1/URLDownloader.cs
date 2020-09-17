using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class URLDownloader
    {
        private string urlString;

        public URLDownloader(string newURL)
        {
            this.urlString = newURL;
        }

        public string getURLString()
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                Stream stream = webClient.OpenRead(this.urlString);
                StreamReader streamReader = new StreamReader(stream);

                string urlAsString = streamReader.ReadToEnd();
                streamReader.Close();
                stream.Close();

                return urlAsString;
            }

            catch
            {
                return null;
            }
        }

    }
}
