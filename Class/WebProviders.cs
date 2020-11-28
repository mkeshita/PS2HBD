using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using PS2HBD.Forms;

namespace PS2HBD
{
    class WebProviders
    {
        private uxMain frmMain;

        public WebProviders(uxMain form)
        {
            frmMain = form;
        }

        public void Check(string baseUrl)
        {
            try
            {
                if (baseUrl.Contains("vimeo"))
                {
                    WebClient wc = new WebClient();
                    wc.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/536.5 (KHTML, like Gecko) Chrome/19.0.1084.56 Safari/536.5");
                    using (Stream data = wc.OpenRead(baseUrl))
                    {
                        using (StreamReader reader = new StreamReader(data))
                        {
                            string content = reader.ReadToEnd();
                            string pattern = @"((https?|ftp|gopher|telnet|file|notes|ms-help):((//)|(\\\\))+[\w\d:#@%/;$()~_?\+-=\\\.&]*)";
                            MatchCollection matches = Regex.Matches(content, pattern);
                            foreach (Match match in matches)
                            {
                                GroupCollection groups = match.Groups;
                                if (groups[0].Value.StartsWith("https") && groups[0].Value.EndsWith(".mp4"))
                                {
                                   /* frmMain.maxPlayer(groups[0].Value);
                                    try
                                    {
                                        wc.Dispose();
                                        data.Dispose();
                                        reader.Dispose();
                                    }
                                    catch { }*/
                                }
                            }
                        }
                    }
                }
            }
            catch { }
        }
    }
}