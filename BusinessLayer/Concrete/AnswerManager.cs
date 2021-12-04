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
    public class AnswerManager : IAnswerService
    {
        private readonly IAnswerDal _answerDal;

        public AnswerManager(IAnswerDal answerDal)
        {
            _answerDal = answerDal;
        }

        public IResult Add(Answer answer)
        {
            _answerDal.Add(answer);
            return new SuccessResult();
        }

        public IResult Delete(Answer answer)
        {
            _answerDal.Delete(answer);
            return new SuccessResult();
        }

        public IDataResult<Answer> GetAnswer(int id)
        {
            return new SuccessDataResult<Answer>(_answerDal.Get(a => a.Id == id));
        }
        public IDataResult<List<Answer>> GetAnswerByQuestionId(int id)
        {
            return new SuccessDataResult<List<Answer>>(_answerDal.GetAll(a => a.QuestionId == id));
        }
        public IDataResult<List<Answer>> GetAnswers()
        {
            return new SuccessDataResult<List<Answer>>(_answerDal.GetAll());
        }

        public IResult Update(Answer answer)
        {
            _answerDal.Update(answer);
            return new SuccessResult();
        }
    }
}
