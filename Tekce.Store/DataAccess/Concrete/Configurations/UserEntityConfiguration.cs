using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataAccess.Concrete.Configurations
{
    public class UserEntityConfiguration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.CitizenId).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.BirthDate);
            builder.Property(x => x.Gender);
            builder.Property(x => x.PhoneNumber).HasMaxLength(30);
            builder.HasIndex(x => x.CitizenId);
            builder.HasIndex(x => x.PhoneNumber);
        }
    }
}