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
    public partial class FacturaDetalleFormaPago1Mappper
    {
        public partial FacturaDetalleFormaPago1 FacturaFP1ToFacturaFP1DTO(FacturaDetalleFormaPago1DTO facturaDetalleFormaPago1DTO);
        public partial FacturaDetalleFormaPago1DTO FacturaFP1ToFacturaFP1DTO(FacturaDetalleFormaPago1 facturaDetalleFormaPago1);
    }
}
