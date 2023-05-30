using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace _4513_ArdaYuksel_Proje.Entities.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.ID); 

            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.Surname);

            builder.Property(x => x.Email); 

        }
    }
}
   

