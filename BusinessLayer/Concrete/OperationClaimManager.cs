using System.Collections.Generic;
using BusinessLayer.Abstract;
using CoreLayer.Entities.Concrete;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class OperationClaimManager:IOperationClaimService
    {
        private readonly IOperationClaimDal _operationClaimDal;

        public OperationClaimManager(IOperationClaimDal operationClaimDal)
        {
            _operationClaimDal = operationClaimDal;
        }

        public IResult Add(OperationClaim operationClaim)
        {
            _operationClaimDal.Add(operationClaim);
            return new SuccessResult();
        }

        public IDataResult<List<OperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<OperationClaim>>(_operationClaimDal.GetAll());
        }
    }
}