using System;

namespace ObjetoDeTransferencia
{
    public class UsuarioFuncionario : Pessoa
    {

        public int FuncionarioId { get; set; }

        public string Nome { get; set; }

        public int CPF { get; set; }

        public string Email { get; set; }

        public DateTime DataDeNacimento { get; set; }

        public string Senha { get; set; }

    }
}
