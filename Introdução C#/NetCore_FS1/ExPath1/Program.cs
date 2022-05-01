using System;
using System.IO;
using static System.Console;

namespace ExPath1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(" ==== Sistema Operacional Windows 10 ======");
            WriteLine();
            WriteLine($"Path.DirectorySeparatorChar: '{Path.DirectorySeparatorChar}'");
            WriteLine($"Path.AltDirectorySeparatorChar: '{Path.AltDirectorySeparatorChar}'");
            WriteLine($"Path.PathSeparator: '{Path.PathSeparator}'");
            WriteLine($"Path.VolumeSeparatorChar: '{Path.VolumeSeparatorChar}'");
            var invalidChars = Path.GetInvalidPathChars();
            WriteLine($"Path.GetInvalidPathChars:");
            for (int ctr = 0; ctr < invalidChars.Length; ctr++)
            {
                Write($"  U+{Convert.ToUInt16(invalidChars[ctr]):X4} ");
                if ((ctr + 1) % 10 == 0) Console.WriteLine();
            }
            WriteLine();
            WriteLine("---------------------------------------");
            WriteLine($"GetTempPath : {Path.GetTempPath()}");
            WriteLine($"GetTempFileName : {Path.GetTempFileName()}");
            WriteLine($"GetRandomFileName : {Path.GetRandomFileName()}");
            ReadLine();
        }
    }
}
