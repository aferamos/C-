using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 

namespace BarberShop.DoMain
{

    #region Observações

    /** ******************************************************************************************* **
     ** Procedure Name..: Agenda	                                                                **
     ** Description.....:                                                                           **                                                                    **
     **                                                                                                                                                                                                **
     ** Autor / Empresa.:Alessandro Ferreira Ramos                                                  **
     ** Especificacao...: Crianda a classe com os atributos da Tabela Agenda                        **
     ** Data de Criacao.:28/08/2019                                                                 **
     ** ******************************************************************************************* **
     ** 
     ** ******************************************************************************************* **/

    #endregion
    public class Agenda
    {
        public Agenda()
        {
            // Construtor ctor
            Data = DateTime.Now;
        }

        #region Anotações de dados Code First
                /** ******************************************************************************************* **
                 ** Procedure Name..: Agenda	                                                                **
                 ** Description.....:                                                                           **
                 **                                                                                             **
                 ** Autor / Empresa.:Alessandro Ferreira Ramos                                                  **
                 ** Especificacao...: Crianda a classe com os atributos da Tabela Agenda                        **
                 ** Data de Criacao.:28/08/2019                                                                 **
                 ** ******************************************************************************************* **
                 ** 
                 * 
                 * Entity Framework Code First permite que você use suas próprias classes de domínio para 
                 * representar o modelo de EF depende para executar a consulta, altere de controle e a 
                 * atualização de funções. Código primeiro aproveita um padrão de programação conhecido 
                 * como 'convenção em detrimento da configuração'. Código primeiro pressupor que suas 
                 * classes de seguem as convenções do Entity Framework e nesse caso, funcionarão automaticamente 
                 * como realizar seu trabalho. No entanto, se suas classes não seguir essas convenções, você tem a 
                 * capacidade de adicionar as configurações para suas classes para fornecer o EF com as informações necessárias.
                 * Código primeiro oferece duas maneiras de adicionar essas configurações para suas classes. Uma é usando 
                 * atributos simples chamados DataAnnotations, e o segundo é usando a API do Fluent do Code First, que fornece uma
                 * maneira de descrever as configurações de modo imperativo, no código. Este artigo se concentra no uso de 
                 * DataAnnotations (no namespace DataAnnotations) para configurar classes – realçando as configurações mais necessárias. 
                 * DataAnnotations também são compreendidas por um número de aplicativos .NET, como o ASP.NET MVC, que permite 
                 * que esses aplicativos para aproveitar as mesmas anotações para validações do lado do cliente.
                 ** ******************************************************************************************* **/

                //[Required (ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]// Parâmetros:  ErrorMessage - Define a mensagem de erro;  e    AllowEmptyStrings - Define se são permitidos valores em branco;

                // prop
                [Key]
                public int Id { get; set; }

                [Required] //- Obriga a entrada de um campo especificado.
                [Display(Name = "Data do atendimento")]
                [Column("Data", TypeName = "Date")]
                [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
                public DateTime Data { get; set; }

                [Required]
                [Column("Ano", TypeName = "int")]
                public int Ano { get; set; }

                [Required]
                [Column("Mes", TypeName = "int")]
                public int Mes { get; set; }

                [Required]
                [Column("Dia", TypeName = "int")]
                public int Dia { get; set; }
        
                [Required]
                [Display(Name = "Informe o mes")]
                [StringLength(9)]
                public string Mes_Nome { get; set; }


                [Required]
                [Display(Name = "Informe o dia da semana")]
                [StringLength(13)]
                public string Dia_Da_Semana_Nome { get; set; }

                [Required]
                [Column("Dia_Do_Ano", TypeName = "int")]
                public int Dia_Do_Ano { get; set; }

                [Required]
                [Column("Dia_Util", TypeName = "int")]
                public int Dia_Util { get; set; }

                [Required]
                [Display(Name = "Data por extenso")]
                [StringLength(60)]
                public string Data_Por_Extenso { get; set; }

                [Required] //- Obriga a entrada de um campo especificado.
                [StringLength(6)]
                public string Ag_Horario { get; set; }

               
        #endregion

        public override string ToString()
        {
            return Data_Por_Extenso;
        }
    }
}
