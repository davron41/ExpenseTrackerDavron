using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Exceptions;
using ExpenseTracker.Domain.Interfaces;
using ExpenseTracker.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Infrastructure.Repositories;

internal sealed class WalletShareRepository : RepositoryBase<WalletShare>, IWalletShareRepository
{
    public WalletShareRepository(ExpenseTrackerDbContext context)
        : base(context)
    {
    }

    public override List<WalletShare> GetAll(Guid userId)
    {
        var walletShares = _context.WalletShares
            .AsNoTracking()
            .Where(x => x.UserId == userId)
            .ToList();

        return walletShares;
    }

    public override WalletShare GetById(int id)
    {
        var walletShare = _context.WalletShares
            .AsNoTracking()
            .Where(x => x.Id == id)
            .Include(x => x.Wallet)
            .ThenInclude(x => x.Owner)
            .FirstOrDefault();

        if (walletShare is null)
        {
            throw new EntityNotFoundException($"Wallet share with id:{id} is not found");
        }

        return walletShare;
    }
}
