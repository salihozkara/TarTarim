using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Question : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SubCategoryId { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
    }
}
