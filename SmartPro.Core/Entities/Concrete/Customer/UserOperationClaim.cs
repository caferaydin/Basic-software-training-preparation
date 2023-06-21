namespace SmartPro.Core.Entities.Concrete.Roles
{
    public class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public Guid OperationClaimId { get; set; }
    }
}
