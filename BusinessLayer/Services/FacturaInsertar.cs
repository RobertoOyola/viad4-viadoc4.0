using EntityLayer.Responses;
using DataLayer.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.DTO;

namespace BusinessLayer.Services
{
    public class FacturaInsertar : IFacturaInsertar
    {
        public readonly IFacturaRepositorio _facturaRepositorio;

        private Response response = new();

        public FacturaInsertar(IFacturaRepositorio facturaRepositorio)
        {
            _facturaRepositorio = facturaRepositorio;
        }

        public async Task<Response> IngresarFactura(Factura1DTO factura1DTO)
        {
            response = await _facturaRepositorio.IngresarFactura(factura1DTO);
            return response;
        }

    }
}
