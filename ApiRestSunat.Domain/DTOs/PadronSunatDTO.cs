﻿using ApiRestSunat.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestSunat.Domain.DTOs
{
    public class PadronSunatDTO : PadronSunat
    {
        //public PadronSunat Padron { get; set; }
        public string Direccion { get; set; }
        public string DireccionLarga { get; set; }
    }
}