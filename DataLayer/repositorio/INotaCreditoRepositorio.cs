using EntityLayer.DTO.NotaCreditoDTO;
using EntityLayer.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.repositorio
{
    public interface INotaCreditoRepositorio
    {
        public Task<Response> IngresarNotaCredito(NotaCreditoDTO notaCreditoDTO);
    }
}
