﻿using CoreLayer.DataAccess;
using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IQuestionDal : IEntityRepository<Question>
    {
        IDataResult<QuestionDto> GetQuestionDto(int id);

    }
}
