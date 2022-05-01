using System.IO;
using static System.Console;

namespace NetCore_FS1
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine(Path.Combine(@"d:\Projetos", "teste.txt"));

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    WriteLine($"Nome do Drive: {drive.Name}");
                    WriteLine($"Formato: {drive.DriveFormat}");
                    WriteLine($"Tipo: {drive.DriveType}");
                    WriteLine($"Diretório Raiz : {drive.RootDirectory}");
                    WriteLine($"Volume label: {drive.VolumeLabel}");
                    WriteLine($"Espaço Livre: {drive.TotalFreeSpace} bytes");
                    WriteLine($"Espaço disponível: {drive.AvailableFreeSpace} bytes");
                    WriteLine($"Tamanho Total: {drive.TotalSize} bytes");
                    WriteLine();
                    ReadLine();
                }
            }
        }
    }
}
