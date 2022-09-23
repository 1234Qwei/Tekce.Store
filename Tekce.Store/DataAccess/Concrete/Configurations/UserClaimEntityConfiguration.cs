using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class UserClaimEntityConfiguration : BaseConfiguration<UserClaim>
    {
        public override void Configure(EntityTypeBuilder<UserClaim> builder)
        {
            builder.HasKey(x => new { x.Id ,x.UserId,x.ClaimId});
            base.Configure(builder);
        }
    }
}