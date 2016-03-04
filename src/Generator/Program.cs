using System.IO;

namespace Elasticsearch.Client.Generator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputPath;
            string classPath;
            string testPath;
            if (args == null || args.Length == 0)
            {
                inputPath = @"C:\elasticsearch-client\lib\rest-api-spec\rest-api-spec\src\main\resources\rest-api-spec\api";
                classPath = @"C:\elasticsearch-client\src\ElasticsearchClient\Generated";
                testPath =  @"C:\elasticsearch-client\src\UnitTests\Generated";
            }
            else
            {
                inputPath = args[0];
                classPath = args[1];
                testPath = args[2];
            }
            var classDirectory = new DirectoryInfo(classPath);
            if (classDirectory.Exists)
            {
                foreach (var info in classDirectory.EnumerateFileSystemInfos())
                {
                    info.Delete();
                }
            }
            var testDirectory = new DirectoryInfo(testPath);
            if (testDirectory.Exists)
            {
                foreach (var info in testDirectory.EnumerateFileSystemInfos())
                {
                    info.Delete();
                }
            }
            Generator.GenerateFromDirectory(inputPath, classPath, testPath);
        }
    }
}
