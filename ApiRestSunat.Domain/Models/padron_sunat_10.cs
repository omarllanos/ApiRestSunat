using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestSunat.Domain.Models
{
    [Table("Padron_sunat_10")]
    public class Padron_sunat_10 : DomainObject
    {
        [StringLength(maximumLength: 11)]
        [Column(TypeName = "VARCHAR(11)")]
        public string Ruc { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string RazonSocial { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Estado { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Condicion { get; set; }

    }
}
