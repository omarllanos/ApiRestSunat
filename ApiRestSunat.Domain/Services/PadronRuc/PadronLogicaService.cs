using ApiRestSunat.Domain.DTOs;
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

        public async Task<PadronSunatDniDTO> GetPadronDni(string ruc)
        {
            var RazonSocial = await _padron10Service.GetPadronDni(ruc);
            if (RazonSocial.Equals(""))
            {
                return null;
            }
            string[] subs = RazonSocial.Split();

            string nombres = "";
            if (subs.Length == 3)
            {
                nombres = subs[subs.Length - 1];
            }
            if (subs.Length == 4)
            {
                nombres = subs[subs.Length - 2] +" "+ subs[subs.Length - 1];
            }
            if (subs.Length == 5)
            {
                nombres = subs[subs.Length - 3] + " " + subs[subs.Length - 2] + " " + subs[subs.Length - 1];
            }
            string apepaterno = subs[0];
            string apematerno = subs[1];
            //var DniValue = ruc.Substring(2, 10);
            PadronSunatDniDTO padronSunatDniDTO = new()
            {
                Dni = ruc,
                Nombres = nombres,
                ApellidoPaterno = apepaterno,
                ApellidoMaterno = apematerno

            };
            return padronSunatDniDTO;
        }

        public async Task<PadronSunatReducidoDTO> GetPadronNaturalRuc(string ruc)
        {
            switch (ruc.Substring(0, 2))
            {
                case "10":
                    var sunat10 = await _padron10Service.GetPadron10(ruc);
                    if (sunat10 != null)
                    {
                        var padronsunat = new PadronSunatReducidoDTO
                        {
                            Ruc = sunat10.Ruc,
                            RazonSocial = sunat10.RazonSocial,
                            Estado = sunat10.Estado,
                            Condicion = sunat10.Condicion

                        };
                        return padronsunat;
                    }
                    else
                    {
                        return null;
                    }

                case "15":
                    var sunat15 = await _padron10Service.GetPadron10(ruc);
                    if (sunat15 != null)
                    {
                        var padronsunat = new PadronSunatReducidoDTO
                        {
                            Ruc = sunat15.Ruc,
                            RazonSocial = sunat15.RazonSocial,
                            Estado = sunat15.Estado,
                            Condicion = sunat15.Condicion

                        };
                        return padronsunat;
                    }
                    else
                    {
                        return null;
                    }
                case "17":
                    var sunat17 = await _padron10Service.GetPadron10(ruc);
                    if (sunat17 != null)
                    {
                        var padronsunat = new PadronSunatReducidoDTO
                        {
                            Ruc = sunat17.Ruc,
                            RazonSocial = sunat17.RazonSocial,
                            Estado = sunat17.Estado,
                            Condicion = sunat17.Condicion

                        };
                        return padronsunat;
                    }
                    else
                    {
                        return null;
                    }

                default:
                    return null;

            }
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
                            Condicion = sunat10.Condicion

                        };
                        return padronsunat;
                    }
                    else
                    {
                        return null;
                    }

                case "15":
                    var sunat15 = await _padron10Service.GetPadron15(ruc);
                    if (sunat15 != null)
                    {
                        var padronsunat = new PadronSunatDTO
                        {
                            Ruc = sunat15.Ruc,
                            RazonSocial = sunat15.RazonSocial,
                            Estado = sunat15.Estado,
                            Condicion = sunat15.Condicion

                        };
                        return padronsunat;
                    }
                    else
                    {
                        return null;
                    }
                case "17":
                    var sunat17 = await _padron10Service.GetPadron17(ruc);
                    if (sunat17 != null)
                    {
                        var padronsunat = new PadronSunatDTO
                        {
                            Ruc = sunat17.Ruc,
                            RazonSocial = sunat17.RazonSocial,
                            Estado = sunat17.Estado,
                            Condicion = sunat17.Condicion

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
                        padronsunat.DireccionLarga = direccion + " - " + sunat20.UDepartamento + " - " + sunat20.UProvincia + " " + sunat20.UDistrito;
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
