using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.DoMain
{
   public class Funcionario
    {
        public Funcionario()
        {

        }
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [StringLength(60)]
        public string Nome { get; set; }

        [Display(Name = "Cpf")]
        [StringLength(11)]
        public string Cpf { get; set; }

        [Display(Name = "Email")]
        [StringLength(30)]
        public string Email { get; set; }

        [Display(Name = "Status")]
        [StringLength(1)]
        public string Status { get; set; }

        [Display(Name = "Acesso")]
        [StringLength(1)]
        public string Acesso { get; set; }

        [Required]
        [Display(Name = "Data do Cadastro")]
        [Column("DtCadastro", TypeName = "Date")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DtCadastro { get; set; }

        [Required]
        [Display(Name = "Data do Alteracao")]
        [Column("DtAlteracao", TypeName = "Date")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DtAlteracao { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public int CargoId { get; set; }

        public virtual Cargo Cargo { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
