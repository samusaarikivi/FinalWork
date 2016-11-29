using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace FinalWork
{
    class Program
    {
        static void Main(string[] args)
        {
            RegKeys.Create();
            switch (args[0])
            {
                case "-r":
                    RegKeys.Read(args[1]);
                    break;
            }
        }
    }
}
