using System;
using System.IO.Compression;

namespace ZipManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            using ZipArchive zipFile = ZipFile.Open("zipfile.zip", ZipArchiveMode.Create);
            ZipArchiveEntry zipArhive = zipFile.CreateEntryFromFile("output.txt", "outputEntry.txt");
            ;
        }
    }
}
