using DatingChat.DataAccess.Repository.IRepository;
using DatingChat.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dating_Chat_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class appUserController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public appUserController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
                
        }

        [HttpGet]
        [Route("users")]
        public IActionResult GetUsers()
        {
            List<appUser> users = unitOfWork.IappUserRepository.GetAll().ToList();
            return Ok(users);
        }
    }
}
