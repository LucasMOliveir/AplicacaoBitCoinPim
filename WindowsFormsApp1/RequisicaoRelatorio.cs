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
    public partial class RequisicaoRelatorio : Form
    {
        public RequisicaoRelatorio()
        {
            InitializeComponent();
        }

        private void RequisicaoRelatorio_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PimDBDataSetRequisicao.ClienteRequisicao' table. You can move, or remove it, as needed.
            this.ClienteRequisicaoTableAdapter.Fill(this.PimDBDataSetRequisicao.ClienteRequisicao,int.Parse(TxtIdDoCliente.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
