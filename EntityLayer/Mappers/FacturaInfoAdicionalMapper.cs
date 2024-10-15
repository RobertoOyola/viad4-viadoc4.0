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
    public partial class FacturaInfoAdicionalMapper
    {
        public partial FacturaInfoAdicional FacturaInfoAdicionalToFacturaInfoAdicionalDTO(FacturaInfoAdicionalDTO facturaInfoAdicionalDTO);

        public partial FacturaInfoAdicionalDTO FacturaInfoAdicionalToFacturaInfoAdicionalDTO(FacturaInfoAdicional facturaInfoAdicional);
    }
}
