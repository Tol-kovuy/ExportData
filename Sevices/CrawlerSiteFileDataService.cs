using Abp.Domain.Repositories;
using ExportData.Entities;
using ExportData.Sevices.FileData;

namespace ExportData.Sevices
{
    public abstract class CrawlerSiteFileDataService
    {
        private readonly IFileDataService _fileDataServise;
        private readonly IRepository<CrawlerSite, Guid> _repository;

        protected CrawlerSiteFileDataService(
            IFileDataService exportDataAppService,
            IRepository<CrawlerSite, Guid> repository
            )
        {
            _fileDataServise = exportDataAppService;
            _repository = repository;
        }

        public async Task<string> SaveDataToJsonAsync<T>(Guid sideId, T obj)
        {
            var site = _repository.Get(sideId);
            var relativeFilePath = $"{site.CrawlerProjectId}{Path.DirectorySeparatorChar}{site.Id}";
            return await _fileDataServise.SaveAsync(relativeFilePath, obj);
        }
    }
}
