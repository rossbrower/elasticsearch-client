using System.IO;

namespace Elasticsearch.Client.Generator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputPath = args[0];
            var outputPath = args[1];
            var directoryInfo = new DirectoryInfo(outputPath);
            if (directoryInfo.Exists)
            {
                foreach (var info in directoryInfo.EnumerateFileSystemInfos())
                {
                    info.Delete();
                }
            }
            Generator.GenerateFromDirectory(inputPath, outputPath);
        }
    }
}
