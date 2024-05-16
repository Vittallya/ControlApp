using ControlApp.Core.Entities;

namespace ControlApp.Core.Interfaces;

public interface IReportService
{
    void CreateReport<T>(IReadOnlyCollection<T> entities, string filePath)
        where T : IEntity;
}
