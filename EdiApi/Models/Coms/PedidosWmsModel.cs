﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdiApi.Models
{
    public class PedidosWmsModel
    {
        public int ClienteId { get; set; }
        public string PedidoBarcode { get; set; }
        public string FechaPedido { get; set; }
        public string Estatus { get; set; }
        public string NomBodega { get; set; }
        public string Regimen { get; set; }
        public string CodProducto { get; set; }
        public double Cantidad { get; set; }
        public string Observacion { get; set; }
        public int PedidoId { get; set; }
    }
}
