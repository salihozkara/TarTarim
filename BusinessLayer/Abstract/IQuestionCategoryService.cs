using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IQuestionCategoryService
    {
        IDataResult<List<QuestionCategory>> GetQuestionCategories();
        IResult Add(QuestionCategory questionCategory);
        IResult Update(QuestionCategory questionCategory);
        IResult Delete(QuestionCategory questionCategory);
        IDataResult<QuestionCategory> GetQuestion(int id);
    }
}
