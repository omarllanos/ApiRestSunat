using ApiRestSunat.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestSunat.Domain.DTOs
{
    public class PadronSelectDTO : PadronSunat
    {
        public string UDepartamento { get; set; }
        public string UProvincia { get; set; }
        public string UDistrito { get; set; }
    }
}
