namespace ElCerrojoServices.Interfaces
{
    public interface ICommonService
    {
        Task ImportExcel(
            string filePath,
            IProgress<int>? progress = null,
            CancellationToken cancellationToken = default
        );
    }
}
