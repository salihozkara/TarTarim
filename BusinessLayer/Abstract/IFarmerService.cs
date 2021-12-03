using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IFarmerService
    {
        IDataResult<List<Farmer>> GetFarmers();
        IResult Add(Farmer farmer);
        IResult Update(Farmer farmer);
        IResult Delete(Farmer farmer);
        IDataResult<Farmer> GetFarmerById(int id);
    }
}
