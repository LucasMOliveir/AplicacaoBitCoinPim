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

        public void AtualizarEndereco()
        {
            EnderecoColecao enderecoColecao = new EnderecoColecao();
            EnderecoNegocios enderecoNegocios = new EnderecoNegocios();

            enderecoColecao = enderecoNegocios.ConsultarEndrecoCep("");
            DgvEnderecoDoUsuario.DataSource = null;
            DgvEnderecoDoUsuario.DataSource = enderecoColecao;

            DgvEnderecoDoUsuario.Update();
            DgvEnderecoDoUsuario.Refresh();
        }

        Endereco enderecoSelecionado = new Endereco();
       
        private void BtnSelecionarEndereco_Click(object sender, EventArgs e)
        {
            enderecoSelecionado = (DgvEnderecoDoUsuario.SelectedRows[0].DataBoundItem as Endereco);
            TxtIdEndereco.Text = enderecoSelecionado.EnderecoId.ToString();
        }
    }
}
