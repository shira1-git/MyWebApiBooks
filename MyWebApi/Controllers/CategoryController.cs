using AutoMapper;
using DTO;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Collections.Generic;
using Zxcvbn;

<<<<<<< HEAD
=======


>>>>>>> 288bcff (add configuration)
namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
<<<<<<< HEAD
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ICategoryService categoryService, IMapper mapper, ILogger<CategoryController> logger)
        {
            _categoryService = categoryService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetAllCategories()
        {
            var categories = await _categoryService.Get();

            if (categories.Any())
            {
                return Ok(categories);
            }

            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategoryById(int id)
        {
            try
            {
                var category = await _categoryService.Get(id);

                if (category != null)
                {
                    return Ok(category);
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error retrieving category by ID: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
=======
        private ICategoryService categoryService;
        private IMapper mapper;
        private readonly ILogger<CategoryController> logger;
        public CategoryController(ICategoryService categoryService, IMapper mapper, ILogger<CategoryController> logger)
        {
            this.categoryService = categoryService;
            this.mapper = mapper;
            this.logger = logger;
        }

        [HttpGet]
        
        public async Task<ActionResult<List<Category>>> Get()
        {
            var category = await categoryService.Get();
            //var categoryDto = mapper.Map<List<Category>, List<CategoryDTO>>(category);
            if (category.Count()>0)
                return Ok(category);
            return NoContent();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<List<Category>>> Get(int id)
        {
            try
            {
            var category = await categoryService.Get(id);
                if (category != null)
                    return Ok(category);
                return NoContent();
            }
            catch(Exception e)
            {
                logger.LogError($"get categoryById error {e}");
            }
            return null;
        }

    }
}
>>>>>>> 288bcff (add configuration)
