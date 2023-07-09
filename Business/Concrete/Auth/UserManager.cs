using SmartPro.Business.Abstraction.Auth;
using SmartPro.Business.BusinessAspects.Autofac;
using SmartPro.Core.Aspects.Autofac.Caching;
using SmartPro.Core.Entities.Concrete.Roles;
using SmartPro.Core.Utilities.Result;
using SmartPro.DataAccess.Abstraction;

namespace SmartPro.Business.Concrete.Auth
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        [SecuredOperation("Admin")]
        public IDataResult<List<User>> GetAllUser()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }
    }
}
