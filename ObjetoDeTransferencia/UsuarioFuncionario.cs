using System;

namespace ObjetoDeTransferencia
{
    public class UsuarioFuncionario 
    {
        public int FuncionarioId { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Cargo { get; set; }

        public string Email { get; set; }

        public DateTime DataDeNacimento { get; set; }

        public string TelefoneFixo { get; set; }

        public string TelefoneCelular { get; set; }

        public int EnderecoId { get; set; }

        public string Setor { get; set; }

        public string Senha { get; set; }

    }
}
