using EntityLayer.DTO.FacturaDTO;
using EntityLayer.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.repositorio
{
    public interface IFacturaRepositorio
    {
        public Task<Response> IngresarFactura(Factura1DTO factura1DTO);
    }
}
