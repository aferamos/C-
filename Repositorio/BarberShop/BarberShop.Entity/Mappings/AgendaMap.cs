using BarberShop.DoMain;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
namespace BarberShop.Entity.Mappings
{
  public class AgendaMap: EntityTypeConfiguration<Agenda>
    {
        #region Observações

        /** ******************************************************************************************* **
         ** Class Name..: AgendaMap	                                                                    **
         ** Description.....:                                                                           **                                                                    **
         **                                                                                             **
         ** Autor / Empresa.:Alessandro Ferreira Ramos                                                  **
         ** Especificacao...: Crianda a classe de mapeamento dos atributos da Tabela Agenda             **
         ** Data de Criacao.:28/08/2019                                                                 **
         ** ******************************************************************************************* **
         ** 
         ** ******************************************************************************************* **/

        #endregion

        public AgendaMap()
        {
            ToTable("Agenda");

            HasKey(agenda => new { agenda.Id });

            Property(agenda => agenda.Data).IsRequired();            
            Property(agenda => agenda.Ano).IsRequired();
            Property(agenda => agenda.Mes).IsRequired();
            Property(agenda => agenda.Dia).IsRequired();            
            Property(agenda => agenda.Mes_Nome).HasMaxLength(30).IsRequired();
            Property(agenda => agenda.Dia_Da_Semana_Nome).HasMaxLength(30).IsRequired();
            Property(agenda => agenda.Dia_Do_Ano).IsRequired();            
            Property(agenda => agenda.Dia_Util).IsRequired();
            Property(agenda => agenda.Data_Por_Extenso).HasMaxLength(60).IsRequired();
            Property(agenda => agenda.Ag_Horario).HasMaxLength(30).IsRequired();
            
        }
}
}
