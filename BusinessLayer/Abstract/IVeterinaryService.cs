using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IVeterinaryService
    {
        List<Veterinary> GetVeterinaries();
        void Add(Veterinary veterinary);
        void Update(Veterinary veterinary);
        void Delete(Veterinary veterinary);
        Veterinary GetVeterinaryById(int id);
    }
}
