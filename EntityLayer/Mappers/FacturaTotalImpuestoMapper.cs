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
    public partial class FacturaTotalImpuestoMapper
    {
        public partial FacturaTotalImpuesto FacturaTotalImpuestoToFacturaTotalImpuestoDTO(FacturaTotalImpuestoDTO facturaTotalImpuestoDTO);
        public partial FacturaTotalImpuestoDTO FacturaTotalImpuestoToFacturaTotalImpuestoDTO(FacturaTotalImpuesto facturaTotalImpuesto);
    }
}
