using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IAnswerService
    {
        IDataResult<List<Answer>> GetAnswers();
        IResult Add(Answer answer);
        IResult Update(Answer answer);
        IResult Delete(Answer answer);
        IDataResult<Answer> GetAnswer(int id);
    }
}
