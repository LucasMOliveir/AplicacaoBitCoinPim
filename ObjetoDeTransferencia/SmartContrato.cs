using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoDeTransferencia
{
    public class SmartContrato
    {
        public int ContratoId { get; set; }

        public string TipoContrato { get; set; }

        public DateTime DataCriacao { get; set; }

        public double Valor { get; set; }

        public int ClienteId { get; set; }
    }
}
