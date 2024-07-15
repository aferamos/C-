using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.DoMain
{
    public class Beneficio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [StringLength(60)]
        public string Nome { get; set; }

        [Display(Name = "Valor do Beneficio")]
        [Column("Valor", TypeName = "char(8)")]
        public string Valor { get; set; }

        [Required] //- Obriga a entrada de um campo especificado.
        [StringLength(6)]
        public string Bn_Horario { get; set; }

        [Required]
        [Display(Name = "Data do Beneficio")]
        [Column("DtBeneficio", TypeName = "Date")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DtBeneficio { get; set; }

        [Display(Name = "Status")]
        [StringLength(1)]
        public string Status { get; set; }

    }
}
