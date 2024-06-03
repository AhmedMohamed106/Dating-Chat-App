using DatingChat.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingChat.DataAccess.Repository.IRepository
{
    public interface IappUserRepository : IRepository<appUser>
    {
        void Update(appUser appuser);
    }
}
