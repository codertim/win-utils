using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStuff
{
    internal class FileStuff
    {
        static void ShowDriveInfo()
        {
            Console.WriteLine("########## Drive Info ##########");
            DriveInfo[] infoDrives = DriveInfo.GetDrives();
            foreach (DriveInfo info in infoDrives)
            {
                Console.WriteLine("\n**********");
                Console.WriteLine("  name: {0}", info.Name);
                Console.WriteLine("  drive type: {0}", info.DriveType);

                if (info.IsReady)
                {
                    Console.WriteLine("  volume label: {0}", info.VolumeLabel);
                    Console.WriteLine("  drive format: {0}", info.DriveFormat);
                    Console.WriteLine("  available free space: {0}", info.AvailableFreeSpace);
                    Console.WriteLine("  total free space: {0}", info.TotalFreeSpace);
                    Console.WriteLine("  total size: {0}", info.TotalSize);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Starting ...\n");

            Console.WriteLine("1) Drive Info");
            Console.WriteLine("2) Subdirectories");
            Console.WriteLine("3) File Info");

            string input = Console.ReadLine();
            //Console.WriteLine("input = |{0}|", input);
            if (input == "1")
            {
                ShowDriveInfo();
            }

            Console.WriteLine("\nDone.");
        }
    }
}
