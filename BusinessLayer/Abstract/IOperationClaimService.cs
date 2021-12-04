using System.Collections.Generic;
using CoreLayer.Entities.Concrete;
using CoreLayer.Utilities.Results;

namespace BusinessLayer.Abstract
{
    public interface IOperationClaimService
    {
        IResult Add(OperationClaim operationClaim);
        IDataResult<List<OperationClaim>> GetAll();
    }
}