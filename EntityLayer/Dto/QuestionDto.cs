using CoreLayer.Entities;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dto
{
    public class QuestionDto : IDto
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string UserImage { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }
        public List<ReplyAnswer> ReplyAnswers { get; set; }
    }
}
