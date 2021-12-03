using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IAgriculturalEngineerService
    {
        List<AgriculturalEngineer> GetAgriculturalEngineers();
        void Add(AgriculturalEngineer agriculturalEngineer);
        void Update(AgriculturalEngineer agriculturalEngineer);
        void Delete(AgriculturalEngineer agriculturalEngineer);
        AgriculturalEngineer GetAgriculturalEngineerById(int id);
    }
}
