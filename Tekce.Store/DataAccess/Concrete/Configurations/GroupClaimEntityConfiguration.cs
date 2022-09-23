using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class GroupClaimEntityConfiguration : BaseConfiguration<GroupClaim>
    {
        public override void Configure(EntityTypeBuilder<GroupClaim> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => new { x.GroupId, x.ClaimId });
        }
    }
}