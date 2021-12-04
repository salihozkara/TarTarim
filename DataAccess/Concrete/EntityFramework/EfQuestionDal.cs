using CoreLayer.DataAccess.EntityFramework;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfQuestionDal : EfEntityRepositoryBase<Question, TarTarimContext>, IQuestionDal
    {

    }
}
