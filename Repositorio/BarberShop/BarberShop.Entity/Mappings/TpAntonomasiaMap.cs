using BarberShop.DoMain;
using System.Data.Entity.ModelConfiguration;

namespace BarberShop.Entity.Mappings
{
    public class TpAntonomasiaMap: EntityTypeConfiguration<TpAntonomasia>
    {
        public TpAntonomasiaMap()
        {
            ToTable("TpAntonomasia");

            HasKey(antonomasia => antonomasia.id);
            Property(antonomasia => antonomasia.Descricao).HasMaxLength(30).IsRequired();
        }
    }
}
