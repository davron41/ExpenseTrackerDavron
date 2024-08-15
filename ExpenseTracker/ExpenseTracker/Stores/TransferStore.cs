using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Interfaces;
using ExpenseTracker.Mappings;
using ExpenseTracker.Stores.Interfaces;
using ExpenseTracker.ViewModels.Transfer;

namespace ExpenseTracker.Stores
{
    public class TransferStore : ITransferStore
    {
        private readonly ICommonRepository _repository;

        public TransferStore(ICommonRepository repository)
        {
            _repository = repository;
        }


        public List<TransferViewModel> GetAll(string? search)
        {
            var transfers=_repository.Transfers.GetAll(search);
            var viewModels = transfers
                .Select(x => x.ToViewModel()).ToList();

            return viewModels;
        }

        public TransferViewModel GetById(int id)
        {
            var transfer=_repository.Transfers.GetById(id);
            
            return transfer.ToViewModel();
        }
        public TransferViewModel Create(CreateTransferViewModel transfer)
        {
            ArgumentNullException.ThrowIfNull(transfer);

            var entity=transfer.ToEntity();
            
            var createdTransfer=_repository.Transfers.Create(entity);
            _repository.SaveChanges();

            return createdTransfer.ToViewModel();
        }

        public void Update(TransferViewModel transfer)
        {
            ArgumentNullException.ThrowIfNull(transfer);

            var entity=transfer.ToEntity(); 

            _repository.Transfers.Update(entity);
            _repository.SaveChanges();
        }
        public void Delete(int id)
        {
            _repository.Transfers.Delete(id);
            _repository.SaveChanges();
        }
    }
}
