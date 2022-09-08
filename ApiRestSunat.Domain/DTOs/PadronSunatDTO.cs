using ApiRestSunat.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestSunat.Domain.DTOs
{
    public class PadronSunatDTO
    {
        public string Ruc { get; set; }
        public string RazonSocial { get; set; }
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
        public string Direccion { get; set; }
        public string DireccionLarga { get; set; }
    }
    public class PadronSunatReducidoDTO
    {
        public string Ruc { get; set; }
        public string RazonSocial { get; set; }
        public string Estado { get; set; }
        public string Condicion { get; set; }
    }
}
