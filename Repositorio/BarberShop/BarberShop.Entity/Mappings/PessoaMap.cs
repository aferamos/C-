using System.Data.Entity.ModelConfiguration;
using BarberShop.DoMain;
namespace BarberShop.Entity.Mappings
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            ToTable("Pessoa");
            HasKey(pessoa => pessoa.Id);
            Property(pessoa => pessoa.Nome).HasMaxLength(60).IsRequired();
            Property(pessoa => pessoa.Email).HasMaxLength(30).IsRequired();

            Property(pessoa => pessoa.TipoPessoa).IsRequired();
            Property(pessoa => pessoa.Rg).HasMaxLength(11);
            Property(pessoa => pessoa.Cpf).HasMaxLength(11);
            Property(pessoa => pessoa.Cnpj).HasMaxLength(11);
            Property(pessoa => pessoa.Sexo).HasMaxLength(1);
            Property(pessoa => pessoa.Status).HasMaxLength(1);
            Property(pessoa => pessoa.Acesso).HasMaxLength(1);
            Property(pessoa => pessoa.Usuario).HasMaxLength(5);
            Property(pessoa => pessoa.DtCadastro).IsRequired();
            Property(pessoa => pessoa.DtAlteracao).IsRequired();


            // HasRequired(pessoa => pessoa.Pessoa_Fisica);
            // HasRequired(pessoa => pessoa.Pessoa_Juridica);

        }

    }
}
