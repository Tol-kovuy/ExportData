using ExportData.Enums;

namespace ExportData.Entities;

public class CrawlerCommand
{
    public int Id { get; set; }
    public CommandType Type { get; set; }
    public string Target { get; set; }
    public string Value { get; set; }
    public string Description { get; set; }
    public bool Enabled { get; set; }
}
