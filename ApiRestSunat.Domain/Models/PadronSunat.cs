using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestSunat.Domain.Models
{
    public class PadronSunat : DomainObject
    {
        [Column(TypeName = "VARCHAR(15)")]
        public string Ruc { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string RazonSocial { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        public string Estado { get; set; }
        public string Condicion { get; set; }
        public string Ubigeo { get; set; }
        public string TipoDeVia { get; set; }
        public string NombreDeVia { get; set; }
        public string CodigoDeZona { get; set; }
        public string TipoDeZona { get; set; }
        public string Numero { get; set; }
        public string Interior { get; set; }
        public string Lote { get; set; }
        public string Departamento { get; set; }
        public string Manzana { get; set; }
        public string Kilometro { get; set; }
        //RUC|NOMBRE O RAZÓN SOCIAL|ESTADO DEL CONTRIBUYENTE|CONDICIÓN DE DOMICILIO|UBIGEO|TIPO DE VÍA|NOMBRE DE VÍA|CÓDIGO DE ZONA|TIPO DE ZONA|NÚMERO|INTERIOR|LOTE|DEPARTAMENTO|MANZANA|KILÓMETRO|
    }
}
