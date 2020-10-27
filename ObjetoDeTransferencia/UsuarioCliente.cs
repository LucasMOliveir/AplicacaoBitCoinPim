using System;

namespace ObjetoDeTransferencia
{
    public class UsuarioCliente : Pessoa
    {
        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public int CPF { get; set; }

        public string Email { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Senha { get; set; }

    }
}
