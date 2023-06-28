using ExportData;
using ExportData.Seeds;

public class Program
{
    public static async Task Main(string[] args)
    {
        #region ExportDataServiceTest

        var list = new List<dynamic>
        {
           new { Name1 = "dsgs", Descgription = "dsafs"},
           new { intt = 345, dec = 456.45m},
           new { value = new { newAnType = "dfgd" } },
           new { an = new { value = new { name = "first"} }, De3345scription = "dsafs", value = new { newAnType = "dfgd" } }
        };

        var projetId = Guid.NewGuid().ToString();

        var test = new ExportDataAppService(projetId);

        await test.SaveDataToCsvAsync(list);
        await test.SaveDataToJsonAsync(list);
        await test.SaveDataToPdfAsync(list);
        await test.SaveDataToTxtAsync(list);

        #endregion

        #region AddCommandsToDb

        var context = new CrawlerDbContext();
        var testWriteCommandsToDb = new CrawlerCommandBuilder(context);
        testWriteCommandsToDb.Create();

        #endregion
    }
}