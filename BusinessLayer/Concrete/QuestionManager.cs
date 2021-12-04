using BusinessLayer.Abstract;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public IResult Add(Question question)
        {
            _questionDal.Add(question);
            return new SuccessResult();
        }

        public IResult Delete(Question question)
        {
            _questionDal.Delete(question);
            return new SuccessResult();
        }

        public IDataResult<Question> GetQuestion(int id)
        {
            return new SuccessDataResult<Question>(_questionDal.Get(q => q.Id == id));
        }

        public IDataResult<List<Question>> GetQuestions()
        {
            return new SuccessDataResult<List<Question>>(_questionDal.GetAll());
        }

        public IResult Update(Question question)
        {
            _questionDal.Update(question);
            return new SuccessResult();
        }
    }
}
