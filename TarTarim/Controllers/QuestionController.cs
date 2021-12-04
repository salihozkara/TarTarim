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
    public class QuestionController : ControllerBase
    {
        IQuestionService _questionService;
        IAnswerService _answerService;

        public QuestionController(IQuestionService questionService, IAnswerService answerService)
        {
            _questionService = questionService;
            _answerService = answerService;
        }

        [HttpGet("getQuestionById")]
        public IActionResult GetQuestionById(int id)
        {
            var result = _questionService.GetQuestion(id);
            
           

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getQuestionByCategoryId")]
        public IActionResult GetQuestionByCategoryId(int id)
        {
            var result = _questionService.GetQuestionByCategoryId(id);



            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
