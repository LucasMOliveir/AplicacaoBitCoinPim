using System;

namespace ObjetoDeTransferencia
{
    public class UsuarioCliente
    {
        int ClienteId { get; set; }

        string Nome { get; set; }

        int CPF { get; set; }

        string Email { get; set; }

        DateTime DataDeNascimento { get; set; }

        string Senha { get; set; }

    }
}
