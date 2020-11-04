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
    public partial class CadastroDeEndereco : Form
    {
        public CadastroDeEndereco()
        {
            InitializeComponent();
            DgvCadastroDeEndereco.AutoGenerateColumns = false;
            Atualizar();
        }

        Endereco endereco = new Endereco();
        Endereco enderecoSelecionado = new Endereco();
        EnderecoColecao enderecoColecao = new EnderecoColecao();
        EnderecoNegocios enderecoNegocios = new EnderecoNegocios();

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            EnderecoInserirFrm enderecoInserirFrm = new EnderecoInserirFrm();
            enderecoInserirFrm.MdiParent = this.MdiParent;
            enderecoInserirFrm.Show();
        }

        public void Atualizar()
        {
            enderecoColecao = enderecoNegocios.ConsultarEndrecoCep(TxtCepEndereco.Text);
            DgvCadastroDeEndereco.DataSource = null;
            DgvCadastroDeEndereco.DataSource = enderecoColecao;

            DgvCadastroDeEndereco.Update();
            DgvCadastroDeEndereco.Refresh();
            
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void BtnConsultarPorID_Click(object sender, EventArgs e)
        {
            enderecoColecao = enderecoNegocios.ConsultarEndrecoId(Convert.ToInt32(TxtIdEndereco.Text));
            DgvCadastroDeEndereco.DataSource = null;
            DgvCadastroDeEndereco.DataSource = enderecoColecao;

            DgvCadastroDeEndereco.Update();
            DgvCadastroDeEndereco.Refresh();
        }

        private void TxtCepEndereco_TextChanged(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (DgvCadastroDeEndereco.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                enderecoSelecionado = (DgvCadastroDeEndereco.SelectedRows[0].DataBoundItem as Endereco);
                EnderecoAlterarFrm enderecoAlterarFrm = new EnderecoAlterarFrm(enderecoSelecionado);
                enderecoAlterarFrm.MdiParent = this.MdiParent;
                enderecoAlterarFrm.Show();
            }
        }
    }
}
