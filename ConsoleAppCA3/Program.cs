using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace ConsoleAppCA3
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("hi");
        }
        public static int GetTextLength(string text, bool includeLeadSpace = true)
        {
            if (!includeLeadSpace)
            {
                return text.Trim().Length;
            }
            else
            {
                return text.Length;
            }
        }

    }
}