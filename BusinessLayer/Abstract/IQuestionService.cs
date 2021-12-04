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
        IDataResult<QuestionDto> GetQuestionDto(int id);
        IDataResult<List<Question>> GetQuestionByCategoryId(int id);
    }
}
