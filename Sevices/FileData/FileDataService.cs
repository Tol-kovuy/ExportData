using Microsoft.AspNetCore.Hosting;

namespace ExportData.Sevices.FileData
{
    public abstract class FileDataService : IFileDataService
    {
        private readonly IWebHostEnvironment _hostEnviroment;

        protected FileDataService(
            IWebHostEnvironment hostEnviroment
            )
        {
            _hostEnviroment = hostEnviroment;
        }

        protected string RootDirectory
        {
            get
            {
                return Path.Combine(_hostEnviroment.WebRootPath, "crawler");
            }
        }
        public abstract Task<string> SaveAsync<T>(string relativeFilePath, T value);
    }
}
