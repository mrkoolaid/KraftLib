using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KraftLib
{
    public class Generators
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="length"></param>
        /// <author>Codeh4ck</author>
        /// <returns></returns>
        private string Codeh4ckRandString(int length)
        {
            string pool = "abcdefghijklmnopqrstuvwxyz";
            pool += pool.ToUpper();
            string tmp = "";
            Random R = new Random();
            for (int x = 0; x < length; x++)
            {
                tmp += pool[R.Next(0, pool.Length)].ToString();
            }
            return tmp;
        }
    }
}
