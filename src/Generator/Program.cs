using System.IO;

namespace Elasticsearch.Client.Generator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputPath;
            string classPath;
            if (args == null || args.Length == 0)
            {
                inputPath = @"C:\elasticsearch-client\lib\rest-api-spec\src\main\resources\rest-api-spec\api";
                classPath = @"C:\elasticsearch-client\src\ElasticsearchClient\Generated";
            }
            else
            {
                inputPath = args[0];
                classPath = args[1];
            }
            var classDirectory = new DirectoryInfo(classPath);
            if (classDirectory.Exists)
            {
                foreach (var info in classDirectory.EnumerateFileSystemInfos())
                {
                    info.Delete();
                }
            }
            using (var generator = new Generator(inputPath, classPath))
            {
               generator.Generate();
            }
        }
    }
}
