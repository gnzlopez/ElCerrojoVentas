namespace ElCerrojoRepository.Interfaces
{
    public interface IRepositoryTransaction
    {
        Task BeginTransaction();
        Task CommitTransaction();
        Task RollbackTransaction();
    }
}
