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
<<<<<<< HEAD

=======
        public IDataResult<QuestionDto> GetQuestionDto(int id)
        {
            return null;
        }
>>>>>>> 99543cdcf4f52ded2c149b958490727804a18db1
    }
}
