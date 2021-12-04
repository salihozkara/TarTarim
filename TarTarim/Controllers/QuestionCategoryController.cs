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
    public class QuestionCategoryController : ControllerBase
    {
        IQuestionCategoryService _questionCategoryService;

        public QuestionCategoryController(IQuestionCategoryService questionCategoryService)
        {
            _questionCategoryService = questionCategoryService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_questionCategoryService.GetQuestionCategories());
        }
        [HttpGet("getQuestionCategoryById")]
        public IActionResult GetQuestionCategoryById(int id)
        {
            var result = _questionCategoryService.GetQuestion(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
