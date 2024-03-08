using dndTracker.Models;

namespace dndTracker.DataAccess.Data.Repository.IRepository
{
    public interface ICharacterRepository : IRepository<Character>
    {
        void Update(Character obj);
    }
}