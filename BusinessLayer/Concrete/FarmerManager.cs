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
    public class FarmerManager : IFarmerService
    {
        IFarmerDal _farmerDal;

        public FarmerManager(IFarmerDal farmerDal)
        {
            _farmerDal = farmerDal;
        }

        public IResult Add(Farmer farmer)
        {
            _farmerDal.Add(farmer);
            return new SuccessResult();
        }

        public IResult Delete(Farmer farmer)
        {
            _farmerDal.Delete(farmer);
            return new SuccessResult();
        }

        public IDataResult<Farmer> GetFarmerById(int id)
        {
            return new SuccessDataResult<Farmer>(_farmerDal.Get(u=>u.Id == id));
        }

        public IDataResult<List<Farmer>> GetFarmers()
        {
            return new SuccessDataResult<List<Farmer>>(_farmerDal.GetAll());
        }

        public IResult Update(Farmer farmer)
        {
            _farmerDal.Update(farmer);
            return new SuccessResult();
        }
    }
}
