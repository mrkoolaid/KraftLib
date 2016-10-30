using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace KraftLib
{
    public class Network
    {
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
    }
}
