using Microsoft.AspNetCore.Mvc;
using NewsSystem.Core.Repositories.Interfaces;

namespace NewsSystem.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserRepository userRepository;
        public AccountController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        
    }
}