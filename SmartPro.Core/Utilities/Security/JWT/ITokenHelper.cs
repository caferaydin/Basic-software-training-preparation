using SmartPro.Core.Entities.Concrete.Roles;

namespace SmartPro.Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
