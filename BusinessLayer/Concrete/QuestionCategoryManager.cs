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
    public class QuestionCategoryManager : IQuestionCategoryService
    {
        IQuestionCategoryDal _questionCategoryDal;
        public IResult Add(QuestionCategory questionCategory)
        {
            _questionCategoryDal.Add(questionCategory);
            return new SuccessResult();
        }

        public IResult Delete(QuestionCategory questionCategory)
        {
            _questionCategoryDal.Delete(questionCategory);
            return new SuccessResult();
        }

        public IDataResult<QuestionCategory> GetQuestion(int id)
        {
            return new SuccessDataResult<QuestionCategory>(_questionCategoryDal.Get(q => q.Id == id));
        }

        public IDataResult<List<QuestionCategory>> GetQuestionCategories()
        {
            return new SuccessDataResult<List<QuestionCategory>>(_questionCategoryDal.GetAll());
        }

        public IResult Update(QuestionCategory questionCategory)
        {
            _questionCategoryDal.Update(questionCategory);
            return new SuccessResult();
        }
    }
}
