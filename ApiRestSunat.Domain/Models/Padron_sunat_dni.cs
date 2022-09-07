using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestSunat.Domain.Models
{
    [Table("Padron_sunat_dni")]
    public class Padron_sunat_dni : DomainObject
    {
        public string Dni { get; set; }
        public string Nombres { get; set; }    
    }
}
