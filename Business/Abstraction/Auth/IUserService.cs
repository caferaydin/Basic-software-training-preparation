using SmartPro.Core.Entities.Concrete.Roles;
using SmartPro.Core.Utilities.Result;

namespace SmartPro.Business.Abstraction.Auth
{
    public interface IUserService
    { 
        List<OperationClaim> GetClaims(User user);
        IDataResult<List<User>> GetAllUser();

        void Add(User user);
        User GetByMail(string email);
    }
}
