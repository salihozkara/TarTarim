using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.Concrete
{
    public class QuestionSubCategory : IEntity
    {
        public int Id { get; set; }
        public int QuestionCategoryId { get; set; }
        public virtual QuestionCategory QuestionCategory { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
