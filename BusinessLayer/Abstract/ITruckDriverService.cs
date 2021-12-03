using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ITruckDriverService
    {
        List<TruckDriver> GetTruckDrivers();
        void Add(TruckDriver truckDriver);
        void Update(TruckDriver truckDriver);
        void Delete(TruckDriver truckDriver);
        TruckDriver GetTruckDriverById(int id);
    }
}
