using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.DoMain
{
    public class TpAntonomasia
    {
        public TpAntonomasia()
        {

        }
        [Key]
        public int id { get; set; }

        [Display(Name = "Descricao")]
        [StringLength(30)]
        public string Descricao { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
