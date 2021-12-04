using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreLayer.Entities.Concrete;

namespace EntityLayer.Concrete
{
    public class Question : IEntity
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public int? QuestionSubCategoryId { get; set; }
        public virtual QuestionSubCategory QuestionSubCategory { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
