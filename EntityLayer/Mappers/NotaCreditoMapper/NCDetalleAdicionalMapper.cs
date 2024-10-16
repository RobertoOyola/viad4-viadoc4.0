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
    public partial class NCDetalleAdicionalMapper
    {
        public partial NotaCreditoDetalleAdicional NCDetalleAdicionalToNCDetalleAdicionalDTO(NotaCreditoDetalleAdicionalDTO notaCreditoDetalleAdicionalDTO);
        public partial NotaCreditoDetalleAdicionalDTO NCDetalleAdicionalToNCDetalleAdicionalDTO(NotaCreditoDetalleAdicional notaCreditoDetalleAdicional);
    }
}
