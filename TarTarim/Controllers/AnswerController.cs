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
    public class AnswerController : ControllerBase
    {
        IAnswerService _answerService;

        public AnswerController(IAnswerService answerService)
        {
            _answerService = answerService;
        }

        [HttpGet("getAnswerById")]
        public IActionResult GetReplyAnswerById(int id)
        {
            var result = _answerService.GetAnswer(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getAnswersForQuestions")]
        public IActionResult GetAnswersForQuestions(int id)
        {
            return Ok(_answerService.GetAnswerByQuestionId(id).Data.Count);
        }
        [HttpGet("getAnswerByQuestionId")]
        public IActionResult GetAnswerByQuestionId(int id)
        {
            var result = _answerService.GetAnswerByQuestionId(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
