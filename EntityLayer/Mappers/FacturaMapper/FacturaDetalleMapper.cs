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
    public partial class FacturaDetalleMapper
    {
        public partial FacturaDetalle1DTO FacturaDetalle1ToFamiliaDetalle1DTO(FacturaDetalle1 facturaDetalle1);

        public partial FacturaDetalle1 FacturaDetalle1ToFamiliaDetalle1DTO(FacturaDetalle1DTO facturaDetalle1DTO);

    }
}
