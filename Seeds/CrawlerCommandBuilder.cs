using CsvHelper.Configuration.Attributes;
using ExportData.Attributs;
using ExportData.Entities;
using ExportData.Enums;
using ExportData.Extensions;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel;
using NameAttribute = ExportData.Attributs.NameAttribute;

namespace ExportData.Seeds;

public class CrawlerCommandBuilder
{
    private readonly CrawlerDbContext _context;

    public CrawlerCommandBuilder(
        CrawlerDbContext context
        )
    {
        _context = context;
    }
    
    public void Create()
    {
        WriteCommandsToDatabase();
    }
    //TODO: Если в базе нет ни одной комманды, то мы тогда берем enum, по каждому enumу проходимся, выгрибаем атрибуты через рефлексию и запихиваем их в базу
    private void WriteCommandsToDatabase()
    {
        var existCommands = _context.CrawlerCommands.IsNullOrEmpty();
        if (existCommands)
        {
            var commands = Enum.GetValues(typeof(CommandType)).Cast<CommandType>();

            foreach (var command in commands)
            {
                var crawlerCommand = new CrawlerCommand
                {
                    Type = command,
                    Target = command.GetAttributeValue<NameAttribute, string>(attr => attr.Name),
                    Description = command.GetAttributeValue<DescriptionAttribute, string>(attr => attr.Description)
                };

            }
        }
    }

}
