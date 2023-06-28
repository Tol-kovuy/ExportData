using Abp.Domain.Entities.Auditing;

namespace ExportData.Entities
{
    public class CrawlerSite : FullAuditedEntity<Guid>
    {
        public string Url { get; set; }
        public ICollection<CrawlerCommand> Commands { get; set; }
        //public ICollection<CrawlerSiteResult> Results { get; set; }
        public Guid CrawlerProjectId { get; set; }
        //public virtual CrawlerProject CrawlerProject { get; set; }
    }
}
