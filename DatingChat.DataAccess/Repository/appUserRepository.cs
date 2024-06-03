using DatingChat.DataAccess.Data;
using DatingChat.DataAccess.Repository.IRepository;
using DatingChat.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingChat.DataAccess.Repository
{
    public class appUserRepository : Repository<appUser>, IappUserRepository
    {

        private ApplicationDbContext _dbContext;

        public appUserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext= dbContext;
        }

        public void Update(appUser appuser)
        {
            var olduser =  _dbContext.appUsers.FirstOrDefault(e=>e.Id == appuser.Id);
            if (olduser != null)
            {
                olduser.Id = appuser.Id;
                olduser.userName = appuser.userName;
            }
            
        }
    }
}
