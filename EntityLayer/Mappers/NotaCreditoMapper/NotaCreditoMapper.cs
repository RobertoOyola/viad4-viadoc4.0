using EntityLayer.DTO.NotaCreditoDTO;
using EntityLayer.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mappers.NotaCreditoMapper
{
    [Mapper]
    public partial class NotaCreditoMapper
    {
        public partial NotaCredito NotaCreditoToNotaCreditoDTO(NotaCreditoDTO notaCreditoDTO);
        public partial NotaCreditoDTO NotaCreditoToNotaCreditoDTO(NotaCredito notaCredito);
    }
}
