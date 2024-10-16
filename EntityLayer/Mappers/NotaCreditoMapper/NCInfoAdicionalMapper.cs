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
    public partial class NCInfoAdicionalMapper
    {
        public partial NotaCreditoInfoAdicional NCInfoAdicionalToNCInfoAdicionalDTO(NotaCreditoInfoAdicionalDTO notaCreditoInfoAdicionalDTO);
        public partial NotaCreditoInfoAdicionalDTO NCInfoAdicionalToNCInfoAdicionalDTO(NotaCreditoInfoAdicional notaCreditoInfoAdicional);
    }
}
