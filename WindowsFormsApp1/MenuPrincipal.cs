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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnCadastroDeFuncionario_Click(object sender, EventArgs e)
        {
            CadastroDeFuncionariosFrm cadastroDeFuncionariosFrm = new CadastroDeFuncionariosFrm();
            cadastroDeFuncionariosFrm.MdiParent = this;
            cadastroDeFuncionariosFrm.Show();
        }

        private void BtnCadastroDeUsuarios_Click(object sender, EventArgs e)
        {
            CadastroDeUsuariosFrm cadastroDeUsuariosFrm = new CadastroDeUsuariosFrm();
            cadastroDeUsuariosFrm.MdiParent = this;
            cadastroDeUsuariosFrm.Show();
        }

        private void BtnCadastroEndereço_Click(object sender, EventArgs e)
        {
            CadastroDeEndereco cadastroDeEndereco = new CadastroDeEndereco();
            cadastroDeEndereco.MdiParent = this;
            cadastroDeEndereco.Show();
        }

        private void BtnGerenciarPedidosERequisicoes_Click(object sender, EventArgs e)
        {
            RequisicoesFrm requisicoesFrm = new RequisicoesFrm();
            requisicoesFrm.MdiParent = this;
            requisicoesFrm.Show();
        }

        private void BtnSmartContrados_Click(object sender, EventArgs e)
        {
            SmartContratosFrm smartContratosFrm = new SmartContratosFrm();
            smartContratosFrm.MdiParent = this;
            smartContratosFrm.Show();
        }
    }
}
