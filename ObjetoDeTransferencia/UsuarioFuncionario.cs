using System;

namespace ObjetoDeTransferencia
{
    public class UsuarioFuncionario : Pessoa
    {
        public int FuncionarioId { get; set; }

        public string Nome { get; set; }

        public  int Rg {get; set;}

        public string Cargo { get; set; }

        public string Email { get; set; }

        public DateTime DataDeNacimento { get; set; }

        public string Setor { get; set; }

        //public string NivelDeAcesso { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public int Cep { get; set; }

        public string TelefoneId { get; set; }

    }
}
