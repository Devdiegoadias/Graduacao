using System;
using System.IO;

namespace Path
{
    class Program
    {

        private static string GetDocumentsFolder() => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        static void Main(string[] args)
        {
            Console.WriteLine(Path.Combine(@"D:\Projects", "ReadMe.txt"));

            Console.WriteLine($"Path.DirectorySeparatorChar: '{Path.DirectorySeparatorChar}'");
            Console.WriteLine($"Path.AltDirectorySeparatorChar: '{Path.AltDirectorySeparatorChar}'");
            Console.WriteLine($"Path.PathSeparator: '{Path.PathSeparator}'");
            Console.WriteLine($"Path.VolumeSeparatorChar: '{Path.VolumeSeparatorChar}'");
            var invalidChars = Path.GetInvalidPathChars();
            Console.WriteLine($"Path.GetInvalidPathChars:");
            for (int ctr = 0; ctr < invalidChars.Length; ctr++)
            {
                Console.Write($"  U+{Convert.ToUInt16(invalidChars[ctr]):X4} ");
                if ((ctr + 1) % 10 == 0) Console.WriteLine();
            }

           

            Console.WriteLine();
        }
    }
}
