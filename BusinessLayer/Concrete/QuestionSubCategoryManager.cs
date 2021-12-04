using BusinessLayer.Abstract;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class QuestionSubCategoryManager : IQuestionSubCategoryService
    {
        IQuestionSubCategoryDal _questionSubCategoryDal;

        public QuestionSubCategoryManager(IQuestionSubCategoryDal questionSubCategoryDal)
        {
            _questionSubCategoryDal = questionSubCategoryDal;
        }

        public IResult Add(QuestionSubCategory questionCategory)
        {
            _questionSubCategoryDal.Add(questionCategory);
            return new SuccessResult();
        }

        public IResult Delete(QuestionSubCategory questionCategory)
        {
            _questionSubCategoryDal.Delete(questionCategory);
            return new SuccessResult();
        }

        public IDataResult<List<QuestionSubCategory>> GetQuestionSubCategories()
        {
            return new SuccessDataResult<List<QuestionSubCategory>>(_questionSubCategoryDal.GetAll());
        }
        public IDataResult<List<QuestionSubCategory>> GetQuestionSubCategoriesByQuestionCategoryId(int id)
        {
            return new SuccessDataResult<List<QuestionSubCategory>>(_questionSubCategoryDal.GetAll(s=>s.QuestionCategoryId==id));
        }
        public IDataResult<QuestionSubCategory> GetQuestionSubCategory(int id)
        {
            return new SuccessDataResult<QuestionSubCategory>(_questionSubCategoryDal.Get(s => s.Id == id));
        }

        public IResult Update(QuestionSubCategory questionCategory)
        {
            _questionSubCategoryDal.Update(questionCategory);
            return new SuccessResult();
        }
    }
}
