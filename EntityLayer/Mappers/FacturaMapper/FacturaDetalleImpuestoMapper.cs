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
    public partial class FacturaDetalleImpuestoMapper
    {
        public partial FacturaDetalleImpuesto1 FacturaDetalleImpuesto1ToFacturaDetalleImpuesto1DTO(FacturaDetalleImpuesto1DTO facturaDetalleImpuesto1DTO);
        public partial FacturaDetalleImpuesto1DTO FacturaDetalleImpuesto1ToFacturaDetalleImpuesto1DTO(FacturaDetalleImpuesto1 facturaDetalleImpuesto1);
    }
}
