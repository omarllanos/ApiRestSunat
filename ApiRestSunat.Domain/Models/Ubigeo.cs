using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestSunat.Domain.Models
{
    [Table("Ubigeo")]
    public class Ubigeo : DomainObject
    {
        [Column(TypeName = "VARCHAR(6)")]
        public string Ubigeo_reniec { get; set; }
        [Column(TypeName = "VARCHAR(6)")]
        public string Ubigeo_inei { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Departamento_inei { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Departamento { get; set; }
        [Column(TypeName = "VARCHAR(6)")]
        public string Provincia_inei { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Provincia { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Distrito { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Region { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Macroregion_inei { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Macroregion_minsa { get; set; }
        [Column(TypeName = "VARCHAR(6)")]
        public string Iso_3166_2 { get; set; }
        [Column(TypeName = "VARCHAR(4)")]
        public string Fips { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal Superficie { get; set; }       
        public int Altitud { get; set; }
        [Column(TypeName = "decimal(14, 8)")]
        public decimal Latitud { get; set; }
        [Column(TypeName = "decimal(14, 8)")]
        public decimal Longitud { get; set; }

    }
}
