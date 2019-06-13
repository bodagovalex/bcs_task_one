using Microsoft.AspNetCore.Mvc;
using Onion.Domain.Core;
using Onion.Domain.Interfaces;
using Onion.Services.Interfaces;

namespace OnionProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        IUserRepository userRepository;
        IUser UserRegistration;

        public UserController(IUserRepository iUserRepository, IUser iUser)
        {
            userRepository = iUserRepository;
            UserRegistration = iUser;
        }

        [HttpGet("")]
        public ActionResult GetUser()
        {
            return Json(userRepository.GetUserList());
        }

        [HttpPost]
        public void AddUser(User user)
        {
            UserRegistration.RegistreUser(user);
        }

        protected override void Dispose(bool disposing)
        {
            userRepository.Dispose();
            UserRegistration.Dispose();
            base.Dispose(disposing);
        }
    }
}
