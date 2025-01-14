﻿using System;
using System.Collections.Generic;

namespace EntityLayer.Models;

public partial class FacturaDetalleFormaPago1
{
    public int CiFacturaDetalleFormaPago { get; set; }

    public int CiCompania { get; set; }

    public string TxEstablecimiento { get; set; } = null!;

    public string TxPuntoEmision { get; set; } = null!;

    public string TxSecuencial { get; set; } = null!;

    public string? TxFormaPago { get; set; }

    public decimal? QnTotal { get; set; }

    public string? TxPlazo { get; set; }

    public string? TxUnidadTiempo { get; set; }
}
