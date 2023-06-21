using Aspose.Cells;
using CsvHelper;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ExportData;

public class ExportDataService : IExportDataService
{
    public string Name { get; set; }
    private readonly string _path = Environment.CurrentDirectory + "\\Results\\";
    private readonly string _fileName;
    private readonly JsonSerializerOptions _options =
       new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };

    public ExportDataService(string projectId)
    {
        Name = projectId;
        _fileName = _path + $"\\{Name}\\" + $"{Name}";
        if (!Directory.Exists(_path + Name))
        {
            Directory.CreateDirectory(_path + Name);
        }
    }
    public Task SaveDataToJsonAsync(object obj)
    {
        var options = new JsonSerializerOptions(_options)
        {
            WriteIndented = true
        };
        var jsonString = JsonSerializer.Serialize(obj, options);
        return File.WriteAllTextAsync($"{_fileName}.json", jsonString);
    }

    public Task SaveDataToCsvAsync(IList<dynamic> objects)
    {
        using var writer = new StreamWriter($"{_fileName}.csv");
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        return csv.WriteRecordsAsync(objects);
    }

    public async Task SaveDataToPdfAsync(IList<dynamic> objects)
    {
        await SaveDataToJsonAsync(objects);
        var workbook = new Workbook($"{_fileName}.json");
        workbook.Save($"{_fileName}.pdf");
    }

    public async Task SaveDataToTxtAsync(IList<dynamic> objects)
    {
        await SaveDataToJsonAsync(objects);
        var workbook = new Workbook($"{_fileName}.json");
        workbook.Save($"{_fileName}.txt");
    }
}
