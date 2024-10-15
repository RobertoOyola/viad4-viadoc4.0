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
    public partial class FacturaMapper
    {
        public partial Factura1DTO Factura1ToFactura1DTO(Factura1 factura1);

        public partial Factura1 Factura1ToFactura1DTO(Factura1DTO factura1DTO);

    }

}
