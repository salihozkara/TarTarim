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
    public class ReplyAnswerManager : IReplyAnswerService
    {
        IReplyAnswerDal _replyAnswerDal;

        public ReplyAnswerManager(IReplyAnswerDal replyAnswerDal)
        {
            _replyAnswerDal = replyAnswerDal;
        }

        public IResult Add(ReplyAnswer replyAnswer)
        {
            _replyAnswerDal.Add(replyAnswer);
            return new SuccessResult();
        }

        public IResult Delete(ReplyAnswer replyAnswer)
        {
            _replyAnswerDal.Delete(replyAnswer);
            return new SuccessResult();
        }

        public IDataResult<ReplyAnswer> GetReplyAnswer(int id)
        {
            return new SuccessDataResult<ReplyAnswer>(_replyAnswerDal.Get(r => r.AnswerId == id));
        }

        public IDataResult<List<ReplyAnswer>> GetReplyAnswers()
        {
            return new SuccessDataResult<List<ReplyAnswer>>(_replyAnswerDal.GetAll());
        }

        public IResult Update(ReplyAnswer replyAnswer)
        {
            _replyAnswerDal.Update(replyAnswer);
            return new SuccessResult();
        }
    }
}
