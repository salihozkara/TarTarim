using System.Collections.Generic;
using CoreLayer.Entities.Concrete;

namespace CoreLayer.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}