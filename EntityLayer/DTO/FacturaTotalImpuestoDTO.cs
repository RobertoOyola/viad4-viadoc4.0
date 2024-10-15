using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTO
{
    public class FacturaTotalImpuestoDTO
    {
        public int CiCompania { get; set; }

        public string TxEstablecimiento { get; set; } = null!;

        public string TxPuntoEmision { get; set; } = null!;

        public string TxSecuencial { get; set; } = null!;

        public string TxCodigo { get; set; } = null!;

        public string TxCodigoPorcentaje { get; set; } = null!;

        public string? TxTarifa { get; set; }

        public decimal? QnDescuentoAdicional { get; set; }

        public decimal QnBaseImponible { get; set; }

        public decimal QnValor { get; set; }
    }
}
