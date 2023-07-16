using SmartPro.Core.Entities.Concrete.Roles;
using SmartPro.Core.Utilities.Result;
using SmartPro.Core.Utilities.Security.JWT;
using SmartPro.Entities.DTO.Product;

namespace SmartPro.Business.Abstraction.Auth
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
