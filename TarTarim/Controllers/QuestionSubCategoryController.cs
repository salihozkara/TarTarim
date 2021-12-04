using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TarTarim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionSubCategoryController : ControllerBase
    {
        IQuestionSubCategoryService _questionSubCategoryService;

        public QuestionSubCategoryController(IQuestionSubCategoryService questionSubCategoryService)
        {
            _questionSubCategoryService = questionSubCategoryService;
        }

        [HttpGet("getQuestionSubCategoryById")]
        public IActionResult GetQuestionSubCategoryById(int id)
        {
            var result = _questionSubCategoryService.GetQuestionSubCategory(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getQuestionCategoryById")]
        public IActionResult GetQuestionCategoryById(int id)
        {
            var result = _questionSubCategoryService.GetQuestionSubCategoriesByQuestionCategoryId(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
