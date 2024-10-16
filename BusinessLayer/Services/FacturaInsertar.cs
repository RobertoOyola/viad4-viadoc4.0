using EntityLayer.Responses;
using DataLayer.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.DTO.FacturaDTO;
using EntityLayer.DTO.NotaCreditoDTO;

namespace BusinessLayer.Services
{
    public class FacturaInsertar : IFacturaInsertar
    {
        public readonly IFacturaRepositorio _facturaRepositorio;
        public readonly INotaCreditoRepositorio _notaCreditoRepositorio;

        private Response response = new();

        public FacturaInsertar(IFacturaRepositorio facturaRepositorio, INotaCreditoRepositorio notaCreditoRepositorio)
        {
            _facturaRepositorio = facturaRepositorio;

            _notaCreditoRepositorio = notaCreditoRepositorio;
        }

        public async Task<Response> IngresarFactura(Factura1DTO factura1DTO)
        {
            response = await _facturaRepositorio.IngresarFactura(factura1DTO);
            return response;
        }

        public async Task<Response> IngresarNotaCredito(NotaCreditoDTO notaCreditoDTO)
        {
            response = await _notaCreditoRepositorio.IngresarNotaCredito(notaCreditoDTO);
            return response;
        }

    }
}
