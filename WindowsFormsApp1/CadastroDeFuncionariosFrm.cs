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

namespace WindowsFormsApp1
{
    public partial class CadastroDeFuncionariosFrm : Form
    {
        public CadastroDeFuncionariosFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroDeFuncionarioInserirFrm cadastroDeFuncionarioInserirFrm = new CadastroDeFuncionarioInserirFrm();
            cadastroDeFuncionarioInserirFrm.MdiParent = this.MdiParent;
            cadastroDeFuncionarioInserirFrm.Show();
        }

        private void BtnAlterarRegistro_Click(object sender, EventArgs e)
        {
            CadastroDeFuncionarioAlterarFrm cadastroDeFuncionarioAlterarFrm = new CadastroDeFuncionarioAlterarFrm();
            cadastroDeFuncionarioAlterarFrm.MdiParent = this.MdiParent;
            cadastroDeFuncionarioAlterarFrm.Show();
        }
    }
}
