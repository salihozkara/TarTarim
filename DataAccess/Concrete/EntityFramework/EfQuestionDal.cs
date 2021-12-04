using System;
using System.IO;
using CoreLayer.DataAccess.EntityFramework;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dto;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfQuestionDal : EfEntityRepositoryBase<Question, TarTarimContext>, IQuestionDal
    {
        public IDataResult<QuestionDto> GetQuestionDto(int id)
        {
            return null;
        }
    }
}
