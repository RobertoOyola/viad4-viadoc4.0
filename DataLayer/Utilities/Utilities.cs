using EntityLayer.Responses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Utilities
{
    public class Utilities
    {
        private readonly FacturacionElectronicaQaContext _context;

        public Utilities(FacturacionElectronicaQaContext context)
        {
            _context = context;
        }


        public async Task<Response> ComprobarClaveacceso(string claveacceso, string tipoDocu)
        {
            Response response = new Response();

            if (tipoDocu == null)
            {
                switch (tipoDocu)
                {
                    case "01":
                        var factura = await _context.Facturas1.FirstOrDefaultAsync(f => f.TxClaveAcceso == claveacceso);
                        if (factura == null)
                        {
                            response.Code = ResponseType.Success;
                            response.Message = string.Empty;
                        }
                        else
                        {
                            response.Code = ResponseType.Error;
                            response.Message = "Existe esa Clave Acceso";
                        }
                        break;

                    case "03":
                        var liquidacion = await _context.Liquidacions.FirstOrDefaultAsync(f => f.TxClaveAcceso == claveacceso);
                        if (liquidacion == null)
                        {
                            response.Code = ResponseType.Success;
                            response.Message = string.Empty;
                        }
                        else
                        {
                            response.Code = ResponseType.Error;
                            response.Message = "Existe esa Clave Acceso";
                        }
                        break;

                    case "04":
                        var notacredito = await _context.NotaCreditos.FirstOrDefaultAsync(f => f.TxClaveAcceso == claveacceso);
                        if (notacredito == null)
                        {
                            response.Code = ResponseType.Success;
                            response.Message = string.Empty;
                        }
                        else
                        {
                            response.Code = ResponseType.Error;
                            response.Message = "Existe esa Clave Acceso";
                        }
                        break;

                    case "05":
                        var notadebito = await _context.NotaDebitos.FirstOrDefaultAsync(f => f.TxClaveAcceso == claveacceso);
                        if (notadebito == null)
                        {
                            response.Code = ResponseType.Success;
                            response.Message = string.Empty;
                        }
                        else
                        {
                            response.Code = ResponseType.Error;
                            response.Message = "Existe esa Clave Acceso";
                        }
                        break;

                    case "06":
                        var guiaremision = await _context.GuiaRemisions.FirstOrDefaultAsync(f => f.TxClaveAcceso == claveacceso);
                        if (guiaremision == null)
                        {
                            response.Code = ResponseType.Success;
                            response.Message = string.Empty;
                        }
                        else
                        {
                            response.Code = ResponseType.Error;
                            response.Message = "Existe esa Clave Acceso";
                        }
                        break;

                    case "07":
                        var comprobanteRetencion = await _context.CompRetencions.FirstOrDefaultAsync(f => f.TxClaveAcceso == claveacceso);
                        if (comprobanteRetencion == null)
                        {
                            response.Code = ResponseType.Success;
                            response.Message = string.Empty;
                        }
                        else
                        {
                            response.Code = ResponseType.Error;
                            response.Message = "Existe esa Clave Acceso";
                        }
                        break;


                    default:
                        response.Code = ResponseType.Error;
                        response.Message = "No ingreso un tipo de documento valido";
                        break;
                }

                return response;
            }
            else
            {
                response.Code = ResponseType.Error;
                response.Message = "No envio ninguna clave de acceso";
                response.Data = claveacceso;
                return response;
            }
        }
    }
}
