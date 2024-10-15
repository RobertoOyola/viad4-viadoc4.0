﻿using EntityLayer.DTO;
using EntityLayer.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IFacturaInsertar
    {
        public Task<Response> IngresarFactura(Factura1DTO factura1DTO);
    }
}
