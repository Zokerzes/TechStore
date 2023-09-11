using Microsoft.AspNetCore.Mvc;
using TechStore.Interfaces;
using TechStore.Models;

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

        [HttpGet("{categoryId}")]  //необязательный параметр в {} и в конце маршрута
        public IActionResult GetCategoriesById(int categoryId) 
        {
            var category = _categoryRepository.GetCategory(categoryId);
            return Ok(category);
        }

        [HttpGet]
        public IActionResult GetAllCategoryes()
        {
            var categoies = _categoryRepository.GetCategories();
            return Ok(categoies);
        }


        [HttpGet("test")]
        [HttpGet("word")]
        [HttpGet("rora/bay")]
        public IActionResult Test() 
        {
            return Ok("Test");
        }


        [HttpPost]
        public IActionResult AddCategory(Category category) 
        {
            if (category == null) return BadRequest(); // если пустая категория
            if (!_categoryRepository.CreateCategory(category))
            {
                return StatusCode(500);
            }
            return Ok("Category created succes");
        }

        [HttpDelete("{categoryId}")]
        public IActionResult DeleteCategory(int categoryId)
        {
            if (!_categoryRepository.CategoryExists(categoryId)) return NotFound();

            if (!_categoryRepository.DeleteCategory(categoryId)) return StatusCode(500);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            if (category== null) return BadRequest();
            if (!_categoryRepository.UpdateCategory(category)) return StatusCode(500);

            return Ok();
        }

    }
}
