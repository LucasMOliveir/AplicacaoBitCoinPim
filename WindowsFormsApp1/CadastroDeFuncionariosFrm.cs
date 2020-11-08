using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ObjetoDeTransferencia;
using Negocios;

namespace WindowsFormsApp1
{
    public partial class CadastroDeFuncionariosFrm : Form
    {
        public CadastroDeFuncionariosFrm()
        {
            InitializeComponent();
            Atualizar();
        }

        UsuarioFuncionarioColecao usuarioFuncionariosColecao = new UsuarioFuncionarioColecao();
        FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();
        UsuarioFuncionario funcinarioSelecionado = new UsuarioFuncionario();

        public void Atualizar()
        {
            usuarioFuncionariosColecao = funcionarioNegocios.ConsultarUsuarioPorNome("");
            DgvFuncionarios.DataSource = null;
            DgvFuncionarios.DataSource = usuarioFuncionariosColecao;

            DgvFuncionarios.Update();
            DgvFuncionarios.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroDeFuncionarioInserirFrm cadastroDeFuncionarioInserirFrm = new CadastroDeFuncionarioInserirFrm();
            cadastroDeFuncionarioInserirFrm.MdiParent = this.MdiParent;
            cadastroDeFuncionarioInserirFrm.Show();
        }

        private void BtnAlterarRegistro_Click(object sender, EventArgs e)
        {
            if (DgvFuncionarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                funcinarioSelecionado = DgvFuncionarios.SelectedRows[0].DataBoundItem as UsuarioFuncionario; 
                CadastroDeFuncionarioAlterarFrm cadastroDeFuncionarioAlterarFrm = new CadastroDeFuncionarioAlterarFrm(funcinarioSelecionado);
                cadastroDeFuncionarioAlterarFrm.MdiParent = this.MdiParent;
                cadastroDeFuncionarioAlterarFrm.Show();
            }
            
        }

        private void TxtUsuarioFuncionarioNome_TextChanged(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void TxtUsuarioFuncionarioId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnPesquisarPorId_Click(object sender, EventArgs e)
        {
            if (TxtUsuarioFuncionarioId.Text == "")
            {
                MessageBox.Show("Campo vazio, Verifique", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                usuarioFuncionariosColecao = funcionarioNegocios.ConsultarUsuarioPorId(int.Parse(TxtUsuarioFuncionarioId.Text));
                DgvFuncionarios.DataSource = null;
                DgvFuncionarios.DataSource = usuarioFuncionariosColecao;

                DgvFuncionarios.Update();
                DgvFuncionarios.Refresh();
            }
        }
    }
}
