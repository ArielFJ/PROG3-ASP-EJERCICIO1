using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class NumeroAInvertir
    {
        [Required]
        [Range(0,99)]   
        public int Numero { get; set; }
    }
}
