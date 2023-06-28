using Abp.Dependency;

namespace ExportData.Sevices.FileData
{
    public interface IFileDataService : ISingletonDependency
    {
        Task<string> SaveAsync<T>(string relativeFilePath, T value);
    }
}
