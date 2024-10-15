﻿using System;
using System.Collections.Generic;

namespace EntityLayer.Models;

public partial class GuiaRemisionInfoAdicional
{
    public int CiGuiaRemisionInfoAdicional { get; set; }

    public int CiCompania { get; set; }

    public string TxEstablecimiento { get; set; } = null!;

    public string TxPuntoEmision { get; set; } = null!;

    public string TxSecuencial { get; set; } = null!;

    public string? TxNombre { get; set; }

    public string? TxValor { get; set; }

    public virtual GuiaRemision GuiaRemision { get; set; } = null!;
}
