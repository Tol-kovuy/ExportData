using Abp.Domain.Repositories;
using ExportData.Entities;
using ExportData.Sevices.JsonFileData;

namespace ExportData.Sevices
{
    public class CrawlerSiteJsonFileDataService : CrawlerSiteFileDataService
    {
        private readonly IExportDataAppService _exportDataAppService;
        private readonly IRepository<CrawlerSite, Guid> _repository;

        public CrawlerSiteJsonFileDataService(
            IJsonFileDataService exportDataAppService,
            IRepository<CrawlerSite, Guid> repository
            ) : base(exportDataAppService, repository)
        {
        }
    }
}
