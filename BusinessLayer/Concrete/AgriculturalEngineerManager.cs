using BusinessLayer.Abstract;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AgriculturalEngineerManager : IAgriculturalEngineerService
    {
        IAgriculturalEngineerDal _agriculturalEngineer;

        public AgriculturalEngineerManager(IAgriculturalEngineerDal agriculturalEngineer)
        {
            _agriculturalEngineer = agriculturalEngineer;
        }

        public IResult Add(AgriculturalEngineer agriculturalEngineer)
        {
            _agriculturalEngineer.Add(agriculturalEngineer);
            return new SuccessResult();
        }

        public IResult Delete(AgriculturalEngineer agriculturalEngineer)
        {
            _agriculturalEngineer.Delete(agriculturalEngineer);
            return new SuccessResult();
        }

        public IDataResult<AgriculturalEngineer> GetAgriculturalEngineerById(int id)
        {
            return new SuccessDataResult<AgriculturalEngineer>(_agriculturalEngineer.Get(a => a.Id == id));
        }

        public IDataResult<List<AgriculturalEngineer>> GetAgriculturalEngineers()
        {
            return new SuccessDataResult<List<AgriculturalEngineer>>(_agriculturalEngineer.GetAll());
        }

        public IResult Update(AgriculturalEngineer agriculturalEngineer)
        {
            _agriculturalEngineer.Update(agriculturalEngineer);
            return new SuccessResult();
        }
    }
}
