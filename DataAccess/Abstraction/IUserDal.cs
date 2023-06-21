using SmartPro.Core.DataAccess;
using SmartPro.Core.Entities.Concrete.Roles;

namespace SmartPro.DataAccess.Abstraction
{
    public interface IUserDal: IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
