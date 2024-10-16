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
    public partial class NCTotalImpuestoMapper
    {
        public partial NotaCreditoTotalImpuesto NCTotalImpuestoToNCTotalImpuestoDTO(NotaCreditoTotalImpuestoDTO notaCreditoTotalImpuestoDTO);
        public partial NotaCreditoTotalImpuestoDTO NCTotalImpuestoToNCTotalImpuestoDTO(NotaCreditoTotalImpuesto notaCreditoTotalImpuesto);
    }
}
