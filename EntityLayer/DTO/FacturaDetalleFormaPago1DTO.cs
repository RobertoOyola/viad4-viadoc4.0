using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTO
{
    public class FacturaDetalleFormaPago1DTO
    {

        public int CiCompania { get; set; }

        public string TxEstablecimiento { get; set; } = null!;

        public string TxPuntoEmision { get; set; } = null!;

        public string TxSecuencial { get; set; } = null!;

        public string? TxFormaPago { get; set; }

        public decimal? QnTotal { get; set; }

        public string? TxPlazo { get; set; }

        public string? TxUnidadTiempo { get; set; }
    }
}
