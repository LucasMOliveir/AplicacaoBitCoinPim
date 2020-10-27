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
    public partial class CadastroDeUsuariosFrm : Form
    {
        public CadastroDeUsuariosFrm()
        {
            InitializeComponent();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            CadastroDeUsuarioInserirFrm cadastroDeUsuarioInserirFrm = new CadastroDeUsuarioInserirFrm();
            cadastroDeUsuarioInserirFrm.MdiParent = this.MdiParent;
            cadastroDeUsuarioInserirFrm.Show();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            CadastroDeUsuarioAlterar cadastroDeUsuarioAlterar = new CadastroDeUsuarioAlterar();
            cadastroDeUsuarioAlterar.MdiParent = this.MdiParent;
            cadastroDeUsuarioAlterar.Show();
        }
    }
}
