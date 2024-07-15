using BarberShop.DoMain;
using System.Data.Entity.ModelConfiguration;

namespace BarberShop.Entity.Mappings
{
    public class CargoMap: EntityTypeConfiguration<Cargo>
    {
        public CargoMap()
        {
            ToTable("Cargo");
            HasKey(cargo => cargo.Id);
            Property(cargo => cargo.Descricao).HasMaxLength(60).IsRequired();
        }
    }
}
