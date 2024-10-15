using EntityLayer.DTO;
using EntityLayer.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mappers
{
    [Mapper]
    public partial class FacturaDetalleAdicionalMapper
    {
        public partial FacturaDetalleAdicional FacturaDetalleAdicionalToFacturaDetalleAdicionalDTO(FacturaDetalleAdicionalDTO facturaDetalleAdicionalDTO);
        public partial FacturaDetalleAdicionalDTO FacturaDetalleAdicionalToFacturaDetalleAdicionalDTO(FacturaDetalleAdicional facturaDetalleAdicional);
    }
}
