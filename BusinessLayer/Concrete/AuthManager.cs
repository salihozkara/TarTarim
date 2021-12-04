using BusinessLayer.Abstract;
using CoreLayer.Entities.Concrete;
using CoreLayer.Entities.DTOs;
using CoreLayer.Utilities.Results;
using CoreLayer.Utilities.Security.Hashing;
using CoreLayer.Utilities.Security.JWT;

namespace BusinessLayer.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        //[ValidationAspect(typeof(UserForRegisterDtoValidator))]
        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash,
                out passwordSalt); //şifre hashlaniyor
            var user = new User //bilgiler ile yeni kullanıcı oluşuyor
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };
            _userService.Add(user); //user tablosuna ekleniyor
            _userService.SetClaim(new UserOperationClaim(){OperationClaimId = userForRegisterDto.OperationClaim,UserId = user.Id});
            return new SuccessDataResult<User>(user, "Kayıt oldu");
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck =
                _userService.GetByMail(userForLoginDto.Email).Data; //email ile kullanıcı bilgileri çekiliyor
            if (
                userToCheck ==
                null) //veri yoksa username üzerinden deneniyor yine veri yoksa kullanıcı bulunamadı mesajı
            {
                return new ErrorDataResult<User>("Kullanıcı bulunamadı");
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash,
                userToCheck.PasswordSalt)) //şifre doğru mu
            {
                return new ErrorDataResult<User>("Parola hatası");
            }

            return new SuccessDataResult<User>(userToCheck, "Başarılı giriş");
        }

        public IResult UserExists(UserForRegisterDto userForRegisterDto) //email ve kullanıcı adı eşsiz mi
        {
            if (_userService.GetByMail(userForRegisterDto.Email).Data != null)
            {
                return new ErrorResult("Email adresi sistemde kayıtlı");
            }

            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(IDataResult<User> dataResult) //jwt oluşturma
        {
            var claims = _userService.GetClaims(dataResult.Data).Data; //user üzerinden rolleri çekiliyor
            var accessToken = _tokenHelper.CreateToken(dataResult.Data, claims); //jwt oluşuyor
            return new SuccessDataResult<AccessToken>(accessToken, dataResult.Message);
        }
    }
}