﻿using ApiRestSunat.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestSunat.Domain.Services.PadronRuc
{
    public class PadronLogicaService : IPadronLogicaService
    {
        private readonly IPadron20Service _padron20Service;
        private readonly IPadron10Service _padron10Service;
        public PadronLogicaService(IPadron20Service padron20Service, IPadron10Service padron10Service)
        {
            _padron20Service = padron20Service;
            _padron10Service = padron10Service;
        }

        public async Task<PadronSunatDTO> GetPadronRuc(string ruc)
        {
            switch (ruc.Substring(0,2))
            {
                case "10":
                    var sunat10 = await _padron10Service.GetPadron10(ruc);
                    if (sunat10 != null)
                    {
                        var padronsunat = new PadronSunatDTO
                        {
                            Ruc = sunat10.Ruc,
                            RazonSocial = sunat10.RazonSocial,
                            Estado = sunat10.Estado,
                            Condicion = sunat10.Condicion,
                            Ubigeo = sunat10.Ubigeo,
                            TipoDeVia = sunat10.TipoDeVia,
                            NombreDeVia = sunat10.NombreDeVia,
                            CodigoDeZona = sunat10.CodigoDeZona,
                            TipoDeZona = sunat10.TipoDeZona,
                            Numero = sunat10.Numero,
                            Interior = sunat10.Interior,
                            Lote = sunat10.Lote,
                            Departamento = sunat10.Departamento,
                            Manzana = sunat10.Manzana,
                            Kilometro = sunat10.Kilometro
                        };
                        return padronsunat;
                    }
                    else
                    {
                        return null;
                    }

                case "20":
                    var sunat20 = await _padron20Service.GetPadron20(ruc);
                  
                    string direccion = "";
                    if (sunat20 != null)
                    {
                        var padronsunat = new PadronSunatDTO
                        {                            
                            Ruc = sunat20.Ruc,
                            RazonSocial = sunat20.RazonSocial,
                            Estado = sunat20.Estado,
                            Condicion = sunat20.Condicion,
                            Ubigeo = sunat20.Ubigeo,
                            TipoDeVia = sunat20.TipoDeVia,
                            NombreDeVia = sunat20.NombreDeVia,
                            CodigoDeZona = sunat20.CodigoDeZona,
                            TipoDeZona = sunat20.TipoDeZona,
                            Numero = sunat20.Numero,
                            Interior = sunat20.Interior,
                            Lote = sunat20.Lote,
                            Departamento = sunat20.Departamento,
                            Manzana = sunat20.Manzana,
                            Kilometro = sunat20.Kilometro
                        };
                        if (sunat20.Manzana != "-")
                        {
                            direccion = "MZ." + sunat20.Manzana;
                        }
                        if (sunat20.Lote != "-")
                        {
                            direccion += " LT." + sunat20.Lote;
                        }
                        if (sunat20.TipoDeVia != "-")
                        {
                            direccion += " " + sunat20.TipoDeVia;
                        }
                        if (sunat20.NombreDeVia != "-")
                        {
                            direccion += " " + sunat20.NombreDeVia;
                        }
                        if (sunat20.Numero != "-")
                        {
                            direccion += " NRO." + sunat20.Numero;
                        }
                        if (sunat20.CodigoDeZona != "-")
                        {
                            direccion += " " + sunat20.CodigoDeZona;
                        }
                        if (sunat20.TipoDeZona != "-")
                        {
                            direccion += " " + sunat20.TipoDeZona;
                        }
                        if (sunat20.Departamento != "-")
                        {
                            direccion += " DTO." + sunat20.Departamento;
                        }
                        if (sunat20.Interior != "-")
                        {
                            direccion += " INT." + sunat20.Interior;
                        }
                        padronsunat.Direccion = direccion;
                        padronsunat.DireccionLarga = direccion + " - " + sunat20.UDepartamento + " " + sunat20.UProvincia + " " + sunat20.UDistrito;
                        return padronsunat;
                    }
                    else
                    {
                        return null;
                    }                 
                    //break;
                default:
                    return null;
                    //break;
            }
           
        }
    }
}