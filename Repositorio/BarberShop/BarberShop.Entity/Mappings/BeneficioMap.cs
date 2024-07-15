using BarberShop.DoMain;
using System.Data.Entity.ModelConfiguration;

namespace BarberShop.Entity.Mappings
{
    public class BeneficioMap: EntityTypeConfiguration<Beneficio>
    {
        public BeneficioMap()
        {
            ToTable("Beneficio");
            HasKey(beneficio => beneficio.Id);
            Property(beneficio => beneficio.Nome).HasMaxLength(60).IsRequired();
            Property(beneficio => beneficio.Valor).HasMaxLength(8).IsRequired();
            Property(beneficio => beneficio.Bn_Horario).HasMaxLength(6).IsRequired();
            Property(beneficio => beneficio.DtBeneficio);
            Property(beneficio => beneficio.Status).HasMaxLength(1).IsRequired();
        }
    }
}
