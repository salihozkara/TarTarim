using System.Collections.Generic;
using CoreLayer.Entities.Concrete;
using CoreLayer.Utilities.Results;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IResult Add(User user);
        IDataResult<User> GetByMail(string email);
        IResult Update(User user);
        IDataResult<User> GetById(int userId);
    }
}