using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using BarberShop.DoMain;
namespace BarberShop.Entity.Mappings
{
    public class FuncionarioMap: EntityTypeConfiguration<Funcionario>
    {

        public FuncionarioMap()
        {
            ToTable("Funcionario");
            HasKey(funcionario => funcionario.Id);
            Property(funcionario => funcionario.Nome).HasMaxLength(60).IsRequired();
            Property(funcionario => funcionario.Cpf).HasMaxLength(11);
            Property(funcionario => funcionario.Email).HasMaxLength(30).IsRequired();
            Property(funcionario => funcionario.Status).HasMaxLength(1);
            Property(funcionario => funcionario.Acesso).HasMaxLength(1);
            Property(funcionario => funcionario.UsuarioId);
            Property(funcionario => funcionario.DtCadastro).IsRequired();
            Property(funcionario => funcionario.DtAlteracao);
    
            HasRequired(funcionario => funcionario.Usuario);
            HasRequired(funcionario => funcionario.Cargo);
        }
    }
}
