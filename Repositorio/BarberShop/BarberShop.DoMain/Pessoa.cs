using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarberShop.DoMain
{
    public class Pessoa
    {
        public Pessoa()
        {
            DtCadastro = DateTime.Now;
        }
        [Key]
        public int Id { get; set; }
        
        //public virtual PessoaFisica PessoaFisica { get; set; }

        //public virtual Pessoa_Juridica Pessoa_Juridica { get; set; }

        [Required] 
        [Display(Name = "Nome")]
        [StringLength(60)]
        public string Nome { get; set; }

        [Display(Name = "Email")]
        [StringLength(30)]
        public string Email { get; set; }

        [Display(Name = "Sexo")]
        [StringLength(1)]
        public string Sexo { get; set; }

        [Display(Name = "Status")]
        [StringLength(1)]
        public string Status { get; set; }

        [Display(Name = "Acesso")]
        [StringLength(1)]
        public string Acesso { get; set; }

        [Display(Name = "Usuario")]
        [StringLength(5)]
        public string Usuario { get; set; }

        [Required]
        [Display(Name = "TipoPessoa")]
        public Boolean TipoPessoa { get; set; }
                
        [Display(Name = "Rg")]
        [StringLength(11)]
        public string Rg { get; set; }

        [Display(Name = "Cpf")]
        [StringLength(11)]
        public string Cpf { get; set; }

        [Display(Name = "Cnpj")]
        [StringLength(11)]
        public string Cnpj { get; set; }

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

        public int IdUsuario { get; set; }
        

        public override string ToString()
        {
            return Nome;
        }

    }
}
