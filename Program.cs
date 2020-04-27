using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace HelloDotnetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var subfolder in Directory.GetDirectories("/mnt/uploads"))
            {
                var metadataFilePath = Path.Combine(subfolder, "metadata.json");
                Console.WriteLine($"Reading {metadataFilePath}");
                var metadataFileStream = File.Open(metadataFilePath, FileMode.Open);
            }

            
        }
    }
}
