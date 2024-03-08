namespace dndTracker.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICharacterRepository Character { get; }
        void Save();
    }
}