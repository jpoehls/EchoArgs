using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EchoArgsCS
{
    internal class main
    {
        static void Main()
        {
            Console.WriteLine("# Environment.GetCommandLineArgs()");
            var args = Environment.GetCommandLineArgs();
            for (var i = 0; i < args.Length; i++)
            {
                Console.WriteLine("[{0}]: {1}", i, args[i]);
            }

            Console.WriteLine();
            Console.WriteLine("# Environment.CommandLine");
            Console.WriteLine(Environment.CommandLine);

            //Console.WriteLine();
            //Console.WriteLine("# CommandLineArgvW");
            //args = CommandLineToArgs(Environment.CommandLine);
            //for (var i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine("[{0}]: {1}", i, args[i]);
            //}
        }

        [DllImport("shell32.dll", SetLastError = true)]
        static extern IntPtr CommandLineToArgvW(
            [MarshalAs(UnmanagedType.LPWStr)] string lpCmdLine, out int pNumArgs);

        // Inspired by http://intellitect.com/converting-command-line-string-to-args-using-commandlinetoargvw-api/
        public static string[] CommandLineToArgs(string commandLine)
        {
            int argc;
            var argv = CommandLineToArgvW(commandLine, out argc);
            if (argv == IntPtr.Zero)
                throw new System.ComponentModel.Win32Exception();
            try
            {
                var args = new string[argc];
                for (var i = 0; i < args.Length; i++)
                {
                    var p = Marshal.ReadIntPtr(argv, i * IntPtr.Size);
                    args[i] = Marshal.PtrToStringUni(p);
                }

                return args;
            }
            finally
            {
                Marshal.FreeHGlobal(argv);
            }
        }
    }
}
