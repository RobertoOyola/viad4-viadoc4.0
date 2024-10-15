using EntityLayer.DTO;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.MapeoComun
{
    public class MapperUtility
    {
        public Factura1 MapperFactura1(Factura1DTO factura1DTO)
        {
            Factura1 factura1 = new Factura1();
            factura1.CiCompania = factura1DTO.CiCompania;
            factura1.CiTipoEmision = factura1DTO.CiTipoEmision;
            factura1.TxClaveAcceso = factura1DTO .TxClaveAcceso;
            factura1.CiTipoDocumento = factura1DTO.CiTipoDocumento;
            factura1.TxEstablecimiento = factura1DTO.TxEstablecimiento;
            factura1.TxPuntoEmision = factura1DTO.TxPuntoEmision;
            factura1.TxSecuencial =  factura1DTO.TxSecuencial;
            factura1.TxFechaEmision = factura1DTO.TxFechaEmision;
            factura1.CiTipoIdentificacionComprador = factura1DTO.TxIdentificacionComprador;
            factura1.TxGuiaRemision = factura1DTO.TxGuiaRemision;
            factura1.TxRazonSocialComprador = factura1DTO.TxRazonSocialComprador;
            


            return factura1;
        }



    }
}
