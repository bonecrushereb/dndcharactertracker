using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dndTracker.DataAccess.Data.Repository.IRepository;

namespace dndTracker.DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICharacterRepository Character { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Character = new CharacterRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}