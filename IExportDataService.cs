namespace ExportData
{
    public interface IExportDataService
    {
        Task SaveDataToJsonAsync(object obj);
        Task SaveDataToCsvAsync(IList<dynamic> objects);
        Task SaveDataToPdfAsync(IList<dynamic> objects);
        Task SaveDataToTxtAsync(IList<dynamic> objects);
    }
}