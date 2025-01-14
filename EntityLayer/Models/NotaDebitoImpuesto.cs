﻿using System;
using System.Collections.Generic;

namespace EntityLayer.Models;

public partial class NotaDebitoImpuesto
{
    public int CiCompania { get; set; }

    public string TxEstablecimiento { get; set; } = null!;

    public string TxPuntoEmision { get; set; } = null!;

    public string TxSecuencial { get; set; } = null!;

    public string TxCodigo { get; set; } = null!;

    public string TxCodigoPorcentaje { get; set; } = null!;

    public string TxTarifa { get; set; } = null!;

    public decimal QnBaseImponible { get; set; }

    public decimal QnValor { get; set; }

    public virtual NotaDebito NotaDebito { get; set; } = null!;
}
