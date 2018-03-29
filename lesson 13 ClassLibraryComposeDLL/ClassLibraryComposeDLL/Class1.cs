using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace ClassLibraryComposeDLL
{
    public static class DownloadWeb
    {
        public static string DownloadWebPage(string pageURL)
        {
            WebClient client = new WebClient();

            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Stream data = client.OpenRead(pageURL);
            StreamReader reader = new StreamReader(data);
            return reader.ReadToEnd();
        }
    }
}
