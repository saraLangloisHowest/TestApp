using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Core.Entities;
using WebApplication1.Data;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class ApplicationUsersController : Controller
    {
        private ApplicationDbContext _dbContext;
        public ApplicationUsersController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            //var users = await _dbContext.ApplicationUsers.Select(u=>new BaseViewModel { Id = u.Id.ToString(), Name = u.Lastname}).ToListAsync();
            return View();
        }
    }
}
