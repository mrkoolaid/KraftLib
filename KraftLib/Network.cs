using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using System.Net;

namespace KraftLib
{
    public class Network
    {
        public string download_status = string.Empty;
        private WebClient client = new WebClient();
        private string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private int download_progress = 0, download_perc_finished = 0;
        private string error_msg = string.Empty;

        /// <summary>
        /// Kraftlib Network constructor
        /// </summary>
        public Network()
        {
            client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
        }

        /// <summary>
        /// gets the names of computers connected to the network
        /// </summary>
        /// <returns>Generic string list of names</returns>
        public List<string> getNetworkNames()
        {
            List<string> ret = new List<string>() { };

            DirectoryEntry root = new DirectoryEntry("WinNT:");
            foreach (DirectoryEntry computers in root.Children)
            {
                foreach (DirectoryEntry computer in computers.Children)
                {
                    if (computer.Name != "Schema")
                    {
                        ret.Add(computer.Name);
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// downloads a file from a remote resource to your desktop
        /// </summary>
        /// <param name="location">the uri</param>
        /// <param name="loc_filename">the filename to save it as</param>
        public void downloadToDesktop(string location, string loc_filename)
        {
            try
            {
                client.DownloadFileAsync(new Uri(location), desktop + loc_filename);
            }
            catch(WebException wex)
            {
                error_msg = wex.Message;
            }
            catch(Exception ex)
            {
                error_msg = ex.Message;
            }
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            download_status = "Download completed";
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            download_progress = (int)e.TotalBytesToReceive / 100;
            download_perc_finished = (int)e.BytesReceived / 100;
        }
    }
}
