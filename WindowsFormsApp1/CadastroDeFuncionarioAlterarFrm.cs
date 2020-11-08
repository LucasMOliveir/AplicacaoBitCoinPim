using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using ObjetoDeTransferencia;

namespace WindowsFormsApp1
{
    public partial class CadastroDeFuncionarioAlterarFrm : Form
    {
        public CadastroDeFuncionarioAlterarFrm()
        {
            InitializeComponent();
        }

        Endereco enderecoSelecionado = new Endereco();
        UsuarioFuncionario usuarioFuncionario = new UsuarioFuncionario();
        FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();

        public CadastroDeFuncionarioAlterarFrm(UsuarioFuncionario usuarioFuncionario)
        {
            InitializeComponent();

            TxtIdFuncionario.Text = usuarioFuncionario.FuncionarioId.ToString();
            TxtNomeFuncionario.Text = usuarioFuncionario.Nome;
            TxtCpfFuncionario.Text = usuarioFuncionario.Cpf;
            TxtCargoFuncionario.Text = usuarioFuncionario.Cargo;
            TxtEmailFuncionario.Text = usuarioFuncionario.Email;
            DtpDataNascFuncionario.Value = usuarioFuncionario.DataDeNacimento;
            TxtTelefoneFixoFuncionario.Text = usuarioFuncionario.TelefoneFixo;
            TxtCelularFuncionario.Text = usuarioFuncionario.TelefoneCelular;
            TxtIdEndereco.Text = usuarioFuncionario.EnderecoId.ToString();
            TxtSetorFuncionario.Text = usuarioFuncionario.Setor;
            TxtSenhaFuncionario.Text = usuarioFuncionario.Senha;
        }

        public void AtualizarEndereco()
        {
            EnderecoColecao enderecoColecao = new EnderecoColecao();
            EnderecoNegocios enderecoNegocios = new EnderecoNegocios();

            enderecoColecao = enderecoNegocios.ConsultarEndrecoCep("");
            DgvEnderecoFuncionario.DataSource = null;
            DgvEnderecoFuncionario.DataSource = enderecoColecao;

            DgvEnderecoFuncionario.Update();
            DgvEnderecoFuncionario.Refresh();
        }

        private void CadastroDeFuncionarioAlterarFrm_Load(object sender, EventArgs e)
        {
            AtualizarEndereco();
        }

        private void BtnSelecionarEndereco_Click(object sender, EventArgs e)
        {
            enderecoSelecionado = DgvEnderecoFuncionario.SelectedRows[0].DataBoundItem as Endereco;
            TxtIdEndereco.Text = enderecoSelecionado.EnderecoId.ToString();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            usuarioFuncionario.EnderecoId = int.Parse(TxtIdEndereco.Text);
            usuarioFuncionario.Nome = TxtNomeFuncionario.Text;
            usuarioFuncionario.Cpf = TxtCpfFuncionario.Text;
            usuarioFuncionario.Cargo = TxtCargoFuncionario.Text;
            usuarioFuncionario.Email = TxtEmailFuncionario.Text;
            usuarioFuncionario.DataDeNacimento = DtpDataNascFuncionario.Value;
            usuarioFuncionario.TelefoneFixo = TxtTelefoneFixoFuncionario.Text;
            usuarioFuncionario.TelefoneCelular = TxtCelularFuncionario.Text;
            usuarioFuncionario.EnderecoId = int.Parse(TxtIdEndereco.Text);
            usuarioFuncionario.Setor = TxtSetorFuncionario.Text;
            usuarioFuncionario.Senha = TxtSenhaFuncionario.Text;

            funcionarioNegocios.AlterarUsuario(usuarioFuncionario);
            this.Close();
        }
    }
}
