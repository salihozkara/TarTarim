using CoreLayer.DataAccess.EntityFramework;
using CoreLayer.Entities.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, TarTarimContext>, IUserDal
    {
        public void SetClaim(UserOperationClaim userOperationClaim)
        {
            using (var context=new TarTarimContext())
            {
                context.UserOperationClaims.Add(userOperationClaim);
                context.SaveChanges();
            }
        }
        public List<OperationClaim> GetClaims(User user)
        {
            using (TarTarimContext context = new TarTarimContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.Id == user.Id
                             select new OperationClaim
                             {
                                 Id = operationClaim.Id,
                                 Name = operationClaim.Name
                             };
                return result.ToList();
            }
        }
    }
}
