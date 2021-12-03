using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IReplyAnswerService
    {
        IDataResult<List<ReplyAnswer>> GetReplyAnswers();
        IResult Add(ReplyAnswer replyAnswer);
        IResult Update(ReplyAnswer replyAnswer);
        IResult Delete(ReplyAnswer replyAnswer);
        IDataResult<ReplyAnswer> GetReplyAnswer(int id);
    }
}
