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
    public partial class CadastroDeUsuarioAlterar : Form
    {
        public CadastroDeUsuarioAlterar()
        {
            InitializeComponent();
            Atualizar();
        }

        Endereco enderecoSelecionado = new Endereco();

        public CadastroDeUsuarioAlterar(UsuarioCliente usuarioCliente)
        {
            InitializeComponent();

            TxtIdCliente.Text = usuarioCliente.EnderecoId.ToString();
            TxtNomeCliente.Text = usuarioCliente.Nome;
            TxtCpfCliente.Text = usuarioCliente.CPF;
            TxtEmailCliente.Text = usuarioCliente.Email;
            TxtSenhaCliente.Text = usuarioCliente.Senha;
            TxtTelefoneFixoCliente.Text = usuarioCliente.TelefoneFixo;
            TxtCelularCliente.Text = usuarioCliente.Celular;
            TxtIdEnderecoCliente.Text = usuarioCliente.EnderecoId.ToString();
            DtpDataNascCliente.Value = usuarioCliente.DataDeNascimento;

            Atualizar();
        }

        public void Atualizar()
        {
            EnderecoNegocios enderecoNegocios = new EnderecoNegocios();
            EnderecoColecao enderecoColecao = enderecoNegocios.ConsultarEndrecoCep("");
            DgvEndereco.DataSource = null;
            DgvEndereco.DataSource = enderecoColecao;

            DgvEndereco.Update();
            DgvEndereco.Refresh();
        }

        private void BtnSelecionarEndereco_Click(object sender, EventArgs e)
        {
            enderecoSelecionado = DgvEndereco.SelectedRows[0].DataBoundItem as Endereco;
            TxtIdEnderecoCliente.Text = enderecoSelecionado.EnderecoId.ToString();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            UsuarioCliente usuarioCliente = new UsuarioCliente();
            UsuarioClienteNegocios usuarioClienteNegocios = new UsuarioClienteNegocios();

            usuarioCliente.ClienteId = int.Parse(TxtIdCliente.Text);
            usuarioCliente.Nome = TxtNomeCliente.Text;
            usuarioCliente.CPF = TxtCpfCliente.Text;
            usuarioCliente.Email = TxtEmailCliente.Text;
            usuarioCliente.DataDeNascimento = DtpDataNascCliente.Value;
            usuarioCliente.Senha = TxtSenhaCliente.Text;
            usuarioCliente.TelefoneFixo = TxtTelefoneFixoCliente.Text;
            usuarioCliente.Celular = TxtCelularCliente.Text;
            usuarioCliente.EnderecoId = int.Parse(TxtIdEnderecoCliente.Text);

            usuarioClienteNegocios.AlterarCliente(usuarioCliente);
            this.Close();
        }
    }
}
