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
    public partial class RequisicoesInserirFrm : Form
    {
        public RequisicoesInserirFrm()
        {
            InitializeComponent();
            Atualizar();
        }

        UsuarioCliente usuarioClienteSelecionado = new UsuarioCliente();
        RequisicoesNegocios requisicoesNegocios = new RequisicoesNegocios();

        public void Atualizar()
        {
            UsuarioClienteColecao usuarioClienteColecao = new UsuarioClienteColecao();
            UsuarioClienteNegocios usuarioClienteNegocios = new UsuarioClienteNegocios();
            usuarioClienteColecao = usuarioClienteNegocios.ConsultarClientePorNome("");

            DgvClientes.DataSource = null;
            DgvClientes.DataSource = usuarioClienteColecao;

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
            Requisicoes requisicoes = new Requisicoes();

            if(TxtIdDoCliente.Text == "")
            {
                MessageBox.Show("Nenhum cliente selecionado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                requisicoes.ClienteId = int.Parse(TxtIdDoCliente.Text);
                requisicoes.Data = DtpData.Value;
                requisicoes.QuantidadeDeMoedas = double.Parse(TxtQuantidadeDeMoedas.Text);
                requisicoes.TipoRequisicao = TxtTipoDaRequisicao.Text;
                requisicoes.Valor = double.Parse(TxtValor.Text);

                requisicoesNegocios.InserirRequisicao(requisicoes);
                this.Close();
            }
        }
    }
}
