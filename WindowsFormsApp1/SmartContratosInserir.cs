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
    public partial class SmartContratosInserir : Form
    {
        public SmartContratosInserir()
        {
            InitializeComponent();
            Atualizar();
        }

        UsuarioCliente usuarioClienteSelecionado = new UsuarioCliente();
        SmartContratoNegocios smartContratoNegocios = new SmartContratoNegocios();

        public void Atualizar()
        {
            UsuarioClienteColecao usuarioClientesColecao = new UsuarioClienteColecao();
            UsuarioClienteNegocios usuarioClienteNegocios = new UsuarioClienteNegocios();
            usuarioClientesColecao = usuarioClienteNegocios.ConsultarClientePorNome("");

            DgvClientes.DataSource = null;
            DgvClientes.DataSource = usuarioClientesColecao;

            DgvClientes.Update();
            DgvClientes.Refresh();
        }

        private void BtnSelecionarCliente_Click(object sender, EventArgs e)
        {
            usuarioClienteSelecionado = DgvClientes.SelectedRows[0].DataBoundItem as UsuarioCliente;
            TxtIdDoCliente.Text = usuarioClienteSelecionado.ClienteId.ToString();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SmartContrato smartContrato = new SmartContrato();

            smartContrato.ClienteId = int.Parse(TxtIdDoCliente.Text);
            smartContrato.DataCriacao = DtpDataDaCriação.Value;
            smartContrato.TipoContrato = CbxTipoDoContrato.Text;
            smartContrato.Valor = int.Parse(TxtValor.Text);

            smartContratoNegocios.InserirSmartContrato(smartContrato);
            this.Close();
        }
    }
}
