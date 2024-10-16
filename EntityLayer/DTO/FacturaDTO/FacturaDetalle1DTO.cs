using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTO.FacturaDTO
{
    public class FacturaDetalle1DTO
    {
        public int CiCompania { get; set; }

        public string TxEstablecimiento { get; set; } = null!;

        public string TxPuntoEmision { get; set; } = null!;

        public string TxSecuencial { get; set; } = null!;

        public string TxCodigoPrincipal { get; set; } = null!;

        public string? TxCodigoAuxiliar { get; set; }

        public string TxDescripcion { get; set; } = null!;

        public int QnCantidad { get; set; }

        public decimal? QnPrecioUnitario { get; set; }

        public decimal QnDescuento { get; set; }

        public decimal QnPrecioTotalSinImpuesto { get; set; }

        public List<FacturaDetalleAdicionalDTO> facturaDetalleAdicionalModelo { get; set; }
        public List<FacturaDetalleImpuesto1DTO> facturaDetalleImpuestoModelo { get; set; }

    }
}
