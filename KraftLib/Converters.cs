using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KraftLib
{
    public class Converters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public string GetStrFromBytes(byte[] bytes)
        {
            return Encoding.ASCII.GetString(bytes);
        }
    }
}
