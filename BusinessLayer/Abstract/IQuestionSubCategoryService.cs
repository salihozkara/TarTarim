using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IQuestionSubCategoryService
    {
        IDataResult<List<QuestionSubCategory>> GetQuestionSubCategories();
        IResult Add(QuestionSubCategory questionCategory);
        IResult Update(QuestionSubCategory questionCategory);
        IResult Delete(QuestionSubCategory questionCategory);
        IDataResult<QuestionSubCategory> GetQuestionSubCategory(int id);
    }
}
