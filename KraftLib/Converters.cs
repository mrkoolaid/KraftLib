using System;
using System.Collections.Generic;
using System.IO;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public byte[] GetBytesFromStr(string str)
        {
            return Encoding.ASCII.GetBytes(str);
        }

        /// <summary>
        /// returns a byte array from an int array
        /// </summary>
        /// <param name="ints">the int array to convert</param>
        /// <returns>returns a byte array, byte[]</returns>
        public byte[] getBytesFromIntArr(int[] ints)
        {
            byte[] bytes = new byte[ints.Length * 4];
            for (int ctr = 0; ctr < ints.Length; ctr++)
            {
                Array.Copy(BitConverter.GetBytes(ints[ctr]), 0, bytes, ctr * 4, 4);
            }
            return bytes;
        }


        /// <summary>
        /// makes a safe name for a windows file or directory from your filename
        /// </summary>
        /// <param name="filename">the string to make safe</param>
        /// <returns>string, the new safe filename</returns>
        public string safeWinName(string filename)
        {
            IList<char> invalid = Path.GetInvalidFileNameChars();
            return new string(filename.Select(ch => invalid.Contains(ch) ? Convert.ToChar(invalid.IndexOf(ch) + 65) : ch).ToArray());
        }
    }
}
