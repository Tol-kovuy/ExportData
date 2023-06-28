using ExportData.Sevices.FileData;
using Microsoft.AspNetCore.Hosting;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ExportData.Sevices.JsonFileData
{
    public class JsonFileDataService
        : FileDataService,
        IJsonFileDataService
    {
        private readonly JsonSerializerOptions _options =
           new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };

        public JsonFileDataService
            (IWebHostEnvironment hostEnviroment
            ) : base(hostEnviroment)
        {

        }

        public async override Task<string> SaveAsync<T>(string relativeFilePath, T value)
        {
            var pathToFile = RootDirectory + relativeFilePath;
            CreateDir(pathToFile);
            var options = new JsonSerializerOptions(_options)
            {
                WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(value, options);
            await File.WriteAllTextAsync(pathToFile + ".json", jsonString);
            return pathToFile;
        }

        private static void CreateDir(string pathToFile)
        {
            if (!Directory.Exists(pathToFile))
            {
                Directory.CreateDirectory(pathToFile);
            }
        }
    }
}
