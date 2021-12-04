using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IQuestionService
    {
        IDataResult<List<Question>> GetQuestions();
        IResult Add(Question question);
        IResult Update(Question question);
        IResult Delete(Question question);
        IDataResult<Question> GetQuestion(int id);
<<<<<<< HEAD
=======
        IDataResult<QuestionDto> GetQuestionDto(int id);
        IDataResult<List<Question>> GetQuestionByCategoryId(int id);
>>>>>>> 99543cdcf4f52ded2c149b958490727804a18db1
    }
}
