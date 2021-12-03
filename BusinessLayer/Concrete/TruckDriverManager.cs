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
    public class TruckDriverManager : ITruckDriverService
    {
        ITruckDriverDal _truckDriverDal;

        public TruckDriverManager(ITruckDriverDal truckDriverDal)
        {
            _truckDriverDal = truckDriverDal;
        }

        public IResult Add(TruckDriver truckDriver)
        {
            _truckDriverDal.Add(truckDriver);
            return new SuccessResult();
        }

        public IResult Delete(TruckDriver truckDriver)
        {
            _truckDriverDal.Delete(truckDriver);
            return new SuccessResult();
        }

        public IDataResult<TruckDriver> GetTruckDriverById(int id)
        {
            return new SuccessDataResult<TruckDriver>(_truckDriverDal.Get(t => t.Id == id));
        }

        public IDataResult<List<TruckDriver>> GetTruckDrivers()
        {
            return new SuccessDataResult<List<TruckDriver>>(_truckDriverDal.GetAll());
        }

        public IResult Update(TruckDriver truckDriver)
        {
            _truckDriverDal.Update(truckDriver);
            return new SuccessResult();
        }
    }
}
