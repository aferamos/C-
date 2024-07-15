using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarberShop.DoMain
{
    public class Usuario
    {
        public Usuario()
        {
            DtCadastro = DateTime.Now;
        }
        [Key]
        public int id { get; set; }

        [Display(Name = "Descricao")]
        [StringLength(30)]
        public string Descricao { get; set; }

        [Display(Name = "Senha")]
        [StringLength(4)]
        public string Senha { get; set; }

        [Required]
        [Display(Name = "Data da validade")]
        [Column("Dtexpiracao", TypeName = "Date")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime Dtvalidade { get; set; }

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

        public override string ToString()
        {
            return Descricao;
        }
    }
}