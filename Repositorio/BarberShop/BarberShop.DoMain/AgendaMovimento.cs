using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.DoMain
{
    public class AgendaMovimento
    {
        public AgendaMovimento()
        {
            DtMovimento = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        [Required]
        public int AgendaId { get; set; }
        public virtual Agenda Agenda { get; set; }

        [Required]
        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }

        [Required]
        [Display(Name = "Data do Movimento")]
        [Column("DtAlteracao", TypeName = "Date")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DtMovimento { get; set; }

        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
