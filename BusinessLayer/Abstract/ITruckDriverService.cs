using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ITruckDriverService
    {
        IDataResult<List<TruckDriver>> GetTruckDrivers();
        IResult Add(TruckDriver truckDriver);
        IResult Update(TruckDriver truckDriver);
        IResult Delete(TruckDriver truckDriver);
        IDataResult<TruckDriver> GetTruckDriverById(int id);
    }
}
