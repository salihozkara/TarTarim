using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IVeterinaryService
    {
        IDataResult<List<Veterinary>> GetVeterinaries();
        IResult Add(Veterinary veterinary);
        IResult Update(Veterinary veterinary);
        IResult Delete(Veterinary veterinary);
        IDataResult<Veterinary> GetVeterinaryById(int id);
    }
}
