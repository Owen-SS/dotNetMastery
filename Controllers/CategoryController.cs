using dotNetMastery.Data;
using dotNetMastery.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotNetMastery.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public CategoryController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            List<Category> objCategoriesList = _dbContext.Categories.ToList();
            return View(objCategoriesList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
