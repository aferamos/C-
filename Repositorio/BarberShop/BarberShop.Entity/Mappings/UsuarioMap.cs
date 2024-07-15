using BarberShop.DoMain;
using System.Data.Entity.ModelConfiguration;

namespace BarberShop.Entity.Mappings
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");
            HasKey(usuario => usuario.id);
            Property(usuario => usuario.Descricao).HasMaxLength(30);
            Property(usuario => usuario.Senha).HasMaxLength(4);
            Property(usuario => usuario.Dtvalidade).IsRequired();
            Property(usuario => usuario.DtCadastro).IsRequired();
            Property(usuario => usuario.DtAlteracao);
        }
    }
}
