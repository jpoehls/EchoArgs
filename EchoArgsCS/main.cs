using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EchoArgsCS
{
    internal class main
    {
        static void Main()
        {
            var args = Environment.GetCommandLineArgs();
            for (var i = 0; i < args.Length; i++)
            {
                Console.WriteLine("[{0}]: {1}", i, args[i]);
            }
        }
    }
}
