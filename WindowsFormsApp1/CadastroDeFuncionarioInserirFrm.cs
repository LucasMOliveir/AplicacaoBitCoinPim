using Negocios;
using ObjetoDeTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CadastroDeFuncionarioInserirFrm : Form
    {
        public CadastroDeFuncionarioInserirFrm()
        {
            InitializeComponent();
            AtualizarEndereco();
        }

        EnderecoNegocios enderecoNegocios = new EnderecoNegocios();

        public void AtualizarEndereco()
        {
            EnderecoColecao enderecoColecao = new EnderecoColecao();

            enderecoColecao = enderecoNegocios.ConsultarEndrecoCep("");
            DgvEnderecoDoUsuario.DataSource = null;
            DgvEnderecoDoUsuario.DataSource = enderecoColecao;

            DgvEnderecoDoUsuario.Update();
            DgvEnderecoDoUsuario.Refresh();
        }

        UsuarioFuncionario usuarioFuncionario = new UsuarioFuncionario();
        Endereco enderecoSelecionado = new Endereco();
        FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();

       
        private void BtnSelecionarEndereco_Click(object sender, EventArgs e)
        {
            enderecoSelecionado = (DgvEnderecoDoUsuario.SelectedRows[0].DataBoundItem as Endereco);
            TxtIdEndereco.Text = enderecoSelecionado.EnderecoId.ToString();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            usuarioFuncionario.Nome = TxtNome.Text;
            usuarioFuncionario.Cpf = TxtCpf.Text;
            usuarioFuncionario.Cargo = TxtCargo.Text;
            usuarioFuncionario.Email = TxtEmail.Text;
            usuarioFuncionario.DataDeNacimento = DtpDataNascimento.Value;
            usuarioFuncionario.TelefoneFixo = TxtTelefoneFixo.Text;
            usuarioFuncionario.TelefoneCelular = TxtCelular.Text;
            usuarioFuncionario.EnderecoId = int.Parse(TxtIdEndereco.Text);
            usuarioFuncionario.Setor = TxtSetor.Text;
            usuarioFuncionario.Senha = TxtSenha.Text;

            funcionarioNegocios.InserirUsuarioFuncionario(usuarioFuncionario);
            this.Close();
        }
    }
}
