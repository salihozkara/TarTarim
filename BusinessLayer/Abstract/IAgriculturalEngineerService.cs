using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IAgriculturalEngineerService
    {
        IDataResult<List<AgriculturalEngineer>> GetAgriculturalEngineers();
        IResult Add(AgriculturalEngineer agriculturalEngineer);
        IResult Update(AgriculturalEngineer agriculturalEngineer);
        IResult Delete(AgriculturalEngineer agriculturalEngineer);
        IDataResult<AgriculturalEngineer> GetAgriculturalEngineerById(int id);
    }
}
