using Owen.WebStore.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Owen.WebStore.Infraestructure.Persistence.Map
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("User");

            HasKey(x => x.Id);

            Property(x => x.Email)
                .HasMaxLength(160)
                .IsRequired();

            Property(x => x.Password)
                .HasMaxLength(32)
                .IsFixedLength()
                .IsRequired();

            Property(x => x.IsAdmin)
                .IsRequired();
        }
    }
}
