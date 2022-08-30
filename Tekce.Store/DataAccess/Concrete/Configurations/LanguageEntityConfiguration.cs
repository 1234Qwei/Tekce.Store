using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class LanguageEntityConfiguration : BaseConfiguration<Language>
    {
        public override void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.Property(x => x.Code).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(10).IsRequired();
            builder.HasData(
                new Language { Id =new System.Guid("00000000-0000-0000-0000-000000000000"), Name = "Türkçe", Code = "tr-TR" },
                new Language { Id = new System.Guid("00000000-0000-0000-0000-000000000001"), Name = "English", Code = "en-US" });

            base.Configure(builder);
        }
    }
}