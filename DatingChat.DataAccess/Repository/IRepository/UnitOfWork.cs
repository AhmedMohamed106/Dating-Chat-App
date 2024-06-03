using DatingChat.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingChat.DataAccess.Repository.IRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        /*
         * Inject repositories
         */
    
        public IappUserRepository IappUserRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            IappUserRepository = new appUserRepository(_db);

        }

 

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
