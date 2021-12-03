using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IFarmerService
    {
        List<Farmer> GetFarmers();
        void Add(Farmer farmer);
        void Update(Farmer farmer);
        void Delete(Farmer farmer);
        Farmer GetFarmerById(int id);
    }
}
