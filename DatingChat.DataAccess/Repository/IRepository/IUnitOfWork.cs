using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingChat.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IappUserRepository IappUserRepository { get; }

        void Save();
    }
}
