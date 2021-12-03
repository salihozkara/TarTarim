using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class ReplyAnswer : IEntity
    {
        public int Id { get; set; }
        public int AnswerId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}
