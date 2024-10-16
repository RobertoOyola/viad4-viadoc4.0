using EntityLayer.DTO.FacturaDTO;
using EntityLayer.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mappers.FacturaMapper
{
    [Mapper]
    public partial class FacturaReembolsoMapper
    {
        public partial FacturaReembolsoGasto FacturaReembolsoToFacturaReembolsoDTO(FacturaReembolsoDTO facturaReembolsoDTO);

        public partial FacturaReembolsoDTO FacturaReembolsoToFacturaReembolsoDTO(FacturaReembolsoGasto facturaReembolsoGasto);
    }
}
