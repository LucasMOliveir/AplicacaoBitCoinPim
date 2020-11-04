using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoDeTransferencia
{
    public class Pedidos
    {

        public int PedidoId { get; set; }

        public string TipoPedido { get; set; }

        public string StatusPedido { get; set; }

        public double Valor { get; set; }

        public DateTime DataCompra { get; set; }

        public DateTime DataVenda { get; set; }

        public double Quantidade { get; set; }

        public int ClienteId { get; set; }

    }
}
