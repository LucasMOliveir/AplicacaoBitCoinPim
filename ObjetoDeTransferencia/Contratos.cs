using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoDeTransferencia
{
    public class Contratos
    {
        public int ContratoId { get; set; }

        public string TipoContrato { get; set; }

        public string StatusContrato { get; set; }

        public DateTime Validade { get; set; }

        public DateTime Data { get; set; }

        public double Valor { get; set; }

        public int ClienteId { get; set; }
    }
}
