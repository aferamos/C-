using BarberShop.DoMain;
using System.Data.Entity.ModelConfiguration;

namespace BarberShop.Entity.Mappings
{
    public class SituacaoMap : EntityTypeConfiguration<Situacao>
    {
        public SituacaoMap()
        {
            ToTable("Situacao");
            HasKey(situacao => situacao.Id);
            Property(situacao => situacao.Descricao).HasMaxLength(60).IsRequired();
        }

    }
}
