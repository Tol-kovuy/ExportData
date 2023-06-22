using ExportData.Enums;

namespace ExportData.Attributs;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public class ArgumentTypeAttribute : Attribute
{
    public CrawlerArgType ArgType { get; set; }

    public ArgumentTypeAttribute(CrawlerArgType argType)
    {
        ArgType = argType;
    }
}
