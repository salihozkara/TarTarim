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
    public class VeterinaryManager : IVeterinaryService
    {
        IVeterinaryDal _veterinaryDal;

        public VeterinaryManager(IVeterinaryDal veterinaryDal)
        {
            _veterinaryDal = veterinaryDal;
        }
        public IResult Add(Veterinary veterinary)
        {
            _veterinaryDal.Add(veterinary);
            return new SuccessResult();
        }

        public IResult Delete(Veterinary veterinary)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Veterinary>> GetVeterinaries()
        {
            return new SuccessDataResult<List<Veterinary>>(_veterinaryDal.GetAll());
        }

        public IDataResult<Veterinary> GetVeterinaryById(int id)
        {
            return new SuccessDataResult<Veterinary>(_veterinaryDal.Get(v=>v.Id == id));
        }

        public IResult Update(Veterinary veterinary)
        {
            _veterinaryDal.Update(veterinary);
            return new SuccessResult();
        }
    }
}
