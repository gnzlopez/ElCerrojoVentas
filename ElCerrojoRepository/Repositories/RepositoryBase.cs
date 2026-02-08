using ElCerrojoRepository.DB;
using ElCerrojoRepository.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

public abstract class RepositoryBase : IRepositoryTransaction
{
    protected readonly AppDbContext _context;
    private IDbContextTransaction? _transaction;

    protected RepositoryBase(AppDbContext context)
    {
        _context = context;
    }

    public async Task BeginTransaction()
    {
        if (_transaction == null)
            _transaction = await _context.Database.BeginTransactionAsync();
    }

    public async Task CommitTransaction()
    {
        if (_transaction != null)
        {
            await _context.SaveChangesAsync();
            await _transaction.CommitAsync();
            _transaction.Dispose();
            _transaction = null;
        }
    }

    public async Task RollbackTransaction()
    {
        if (_transaction != null)
        {
            await _transaction.RollbackAsync();
            _transaction.Dispose();
            _transaction = null;
        }
    }
}
