using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTO.NotaCreditoDTO
{
    public class NotaCreditoDetalleDTO
    {
        public int CiCompania { get; set; }

        public string TxEstablecimiento { get; set; } = null!;

        public string TxPuntoEmision { get; set; } = null!;

        public string TxSecuencial { get; set; } = null!;

        public string TxCodigoInterno { get; set; } = null!;

        public string? TxCodigoAdicional { get; set; }

        public string TxDescripcion { get; set; } = null!;

        public int QnCantidad { get; set; }

        public decimal QnPrecioUnitario { get; set; }

        public decimal QnDescuento { get; set; }

        public decimal QnPrecioTotalSinImpuesto { get; set; }
        public List<NotaCreditoDetalleAdicionalDTO> notaCreditoDetalleAdicionalModelo { get; set; }
        public List<NotaCreditoDetalleImpuestoDTO> notaCreditoDetalleImpuestoModelo { get; set; }

    }
}
