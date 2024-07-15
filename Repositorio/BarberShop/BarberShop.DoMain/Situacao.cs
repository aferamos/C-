using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.DoMain
{
    public class Situacao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Descricao")]
        [StringLength(60)]
        public string Descricao { get; set; }

    }
}
