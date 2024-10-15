using System;
using System.Collections.Generic;

namespace EntityLayer.Models;

public partial class TipoAmbiente
{
    public int CiTipoAmbiente { get; set; }

    public string? TxDescrpicion { get; set; }

    public virtual ICollection<Companium> Compania { get; set; } = new List<Companium>();
}
