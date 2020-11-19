using System;

namespace ObjetoDeTransferencia
{
    public class UsuarioCliente
    {
        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Senha { get; set; }

        public string TelefoneFixo { get; set; }

        public string Celular { get; set; }

        public int EnderecoId { get; set; }

    }
}
