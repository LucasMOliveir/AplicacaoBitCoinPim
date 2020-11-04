using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoDeTransferencia
{
    public class Requisicoes
    {
        public int RequisisaoId { get; set; }

        public string StatusRequisicao { get; set; }

        public DateTime Data { get; set; }

        public double Valor { get; set; }

        public double Quantidade { get; set; }

        public DateTime Validade { get; set; }

        public int ClienteId { get; set; }
    }
}
