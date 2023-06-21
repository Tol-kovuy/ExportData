using ExportData;

public class Program
{
    public static async Task Main(string[] args)
    {
        var list = new List<dynamic>
        {
           new { Name1 = "dsgs", Descgription = "dsafs"},
           new { intt = 345, dec = 456.45m},
           new { value = new { newAnType = "dfgd" } },
           new { an = new { value = new { name = "first"} }, De3345scription = "dsafs", value = new { newAnType = "dfgd" } }
        };
        var projetId = Guid.NewGuid().ToString();
        var test = new ExportDataService(projetId);
        await test.SaveDataToCsvAsync(list);
        await test.SaveDataToJsonAsync(list);
        await test.SaveDataToPdfAsync(list);
        await test.SaveDataToTxtAsync(list);
    }
}