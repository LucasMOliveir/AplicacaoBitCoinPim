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
    public partial class CadastroDeUsuarioInserirFrm : Form
    {
        public CadastroDeUsuarioInserirFrm()
        {
            InitializeComponent();
            Atualizar();
        }

        EnderecoNegocios enderecoNegocios = new EnderecoNegocios();
        EnderecoColecao enderecoColecao = new EnderecoColecao();
        Endereco enderecoSelecionado = new Endereco();
        UsuarioCliente usuarioCliente = new UsuarioCliente();
        UsuarioClienteNegocios usuarioClienteNegocios = new UsuarioClienteNegocios();

        public void Atualizar()
        {
            enderecoColecao = enderecoNegocios.ConsultarEndrecoCep("");
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
            usuarioCliente.Nome = TxtNomeCliente.Text;
            usuarioCliente.CPF = TxtCpfCliente.Text;
            usuarioCliente.Email = TxtEmailCliente.Text;
            usuarioCliente.DataDeNascimento = DtpDataDeNascmentoCliente.Value;
            usuarioCliente.Senha = TxtSenhaCliente.Text;
            usuarioCliente.TelefoneFixo = TxtTelefoneFixoCliente.Text;
            usuarioCliente.Celular = TxtCelularCliente.Text;
            usuarioCliente.EnderecoId = int.Parse(TxtIdEnderecoCliente.Text);

            usuarioClienteNegocios.InserirUsuarioCliente(usuarioCliente);
            this.Close();
        }
    }
}
