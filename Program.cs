using System;
using System.IO;

namespace HelloDotnetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var subfolder in Directory.GetDirectories("/mnt/uploads"))
            {
                var metadataFilePath = Path.Combine(subfolder, "metadata.json");
            }

            
        }
    }
}
