using System;
using System.Collections.Generic;
// using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagedWord mw = new ManagedWord();
            mw.Dispose();
            mw.OpenWordDocument("testing");
        }
    }
}
