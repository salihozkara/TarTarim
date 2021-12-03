using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreLayer.Entities.Concrete;

namespace EntityLayer.Concrete
{

    public class Answer : IEntity
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}
