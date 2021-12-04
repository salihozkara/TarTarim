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
    public class ReplyAnswerController : ControllerBase
    {
        IReplyAnswerService _replyAnswerService;

        public ReplyAnswerController(IReplyAnswerService replyAnswerService)
        {
            _replyAnswerService = replyAnswerService;
        }

        [HttpGet("getReplyAnswerByReplyId")]
        public IActionResult GetReplyAnswerById(int id)
        {
            var result = _replyAnswerService.GetReplyAnswer(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
