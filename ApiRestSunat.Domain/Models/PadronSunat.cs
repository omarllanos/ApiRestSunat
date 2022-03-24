using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestSunat.Domain.Models
{
    public class PadronSunat : DomainObject
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
        [Column(TypeName = "VARCHAR(10)")]
        public string Ubigeo { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        public string TipoDeVia { get; set; }
        [Column(TypeName = "VARCHAR(60)")]
        public string NombreDeVia { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string CodigoDeZona { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string TipoDeZona { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        public string Numero { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        public string Interior { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        public string Lote { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        public string Departamento { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        public string Manzana { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        public string Kilometro { get; set; }
       
        //RUC|NOMBRE O RAZÓN SOCIAL|ESTADO DEL CONTRIBUYENTE|CONDICIÓN DE DOMICILIO|UBIGEO|TIPO DE VÍA|NOMBRE DE VÍA|CÓDIGO DE ZONA|TIPO DE ZONA|NÚMERO|INTERIOR|LOTE|DEPARTAMENTO|MANZANA|KILÓMETRO|
    }
}
