using Microsoft.AspNetCore.Mvc;
using TechStore.Interfaces;

namespace TechStore.Controllers
{
    [ApiController]
    [Route("[controller]")] // "/category"
    public class CategoryController:Controller
    {
        public readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult Hello()
        {
            return Ok("Hello");
        }
        [HttpPost]
        public IActionResult AddCategory() 
        {
            
        }
    }
}
