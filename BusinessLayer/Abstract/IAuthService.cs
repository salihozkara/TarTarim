using CoreLayer.Entities.Concrete;
using CoreLayer.Entities.DTOs;
using CoreLayer.Utilities.Results;
using CoreLayer.Utilities.Security.JWT;

namespace BusinessLayer.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(UserForRegisterDto userForRegisterDto);
        IDataResult<AccessToken> CreateAccessToken(IDataResult<User> dataResult);
    }
}