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
using Negocios;

namespace WindowsFormsApp1
{
    public partial class CadastroDeUsuariosFrm : Form
    {
        public CadastroDeUsuariosFrm()
        {
            InitializeComponent();
            DgvCadastroUsuario.AutoGenerateColumns = false;
            Atualizar();
        }

        UsuarioClienteColecao usuarioClienteColecao = new UsuarioClienteColecao();
        UsuarioClienteNegocios usuarioClienteNegocios = new UsuarioClienteNegocios();
        UsuarioCliente usuarioClienteSelecionado = new UsuarioCliente();
        UsuarioCliente usuarioCliente = new UsuarioCliente();

        public void Atualizar()
        {
            usuarioClienteColecao = usuarioClienteNegocios.ConsultarClientePorNome(TxtNome.Text);
            DgvCadastroUsuario.DataSource = null;
            DgvCadastroUsuario.DataSource = usuarioClienteColecao;

            DgvCadastroUsuario.Update();
            DgvCadastroUsuario.Refresh();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            CadastroDeUsuarioInserirFrm cadastroDeUsuarioInserirFrm = new CadastroDeUsuarioInserirFrm();
            cadastroDeUsuarioInserirFrm.MdiParent = this.MdiParent;
            cadastroDeUsuarioInserirFrm.Show();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (DgvCadastroUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhu registro selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                usuarioClienteSelecionado = DgvCadastroUsuario.SelectedRows[0].DataBoundItem as UsuarioCliente;
                CadastroDeUsuarioAlterar cadastroDeUsuarioAlterar = new CadastroDeUsuarioAlterar(usuarioClienteSelecionado);
                cadastroDeUsuarioAlterar.MdiParent = this.MdiParent;
                cadastroDeUsuarioAlterar.Show();
            }
        }

        private void BtnPesquisarPorId_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "")
            {
                MessageBox.Show("Campo vazio, Verifique", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                usuarioClienteColecao = usuarioClienteNegocios.ConsultarClientePorId(int.Parse(TxtId.Text));
                DgvCadastroUsuario.DataSource = null;
                DgvCadastroUsuario.DataSource = usuarioClienteColecao;

                DgvCadastroUsuario.Update();
                DgvCadastroUsuario.Refresh();
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            Atualizar();
        }
    }
}
