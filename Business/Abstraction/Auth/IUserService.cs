using SmartPro.Core.Entities.Concrete.Roles;

namespace SmartPro.Business.Abstraction.Auth
{
    public interface IUserService
    { 
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
