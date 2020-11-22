using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoDeTransferencia;
using Negocios;

namespace WindowsFormsApp1
{
    public partial class SmartContratosFrm : Form
    {
        public SmartContratosFrm()
        {
            InitializeComponent();
            Atualizar();
        }

        SmartContratoNegocios smartcontratoNegocios = new SmartContratoNegocios();
        SmartContrato smartContratoSelecionado = new SmartContrato();

        public void Atualizar()
        {
            SmartContratoColecao smartContratosColecao = new SmartContratoColecao();
            smartContratosColecao = smartcontratoNegocios.ConsultaAmartContrato();

            DgvContratos.DataSource = null;
            DgvContratos.DataSource = smartContratosColecao;

            DgvContratos.Update();
            DgvContratos.Refresh();
        }

        private void BtnCadastrarContrato_Click(object sender, EventArgs e)
        {
            SmartContratosInserir smartContratosInserir = new SmartContratosInserir();
            smartContratosInserir.MdiParent = this.MdiParent;
            smartContratosInserir.Show();
        }

        private void BtnConsultarPorId_Click(object sender, EventArgs e)
        {
            SmartContratoColecao smartContratosColecao = new SmartContratoColecao();
            smartContratosColecao = smartcontratoNegocios.CosultarContratoPorId(Convert.ToInt32(TxtIdDoContrato.Text));

            DgvContratos.DataSource = null;
            DgvContratos.DataSource = smartContratosColecao;


            DgvContratos.Update();
            DgvContratos.Refresh();
        }

        private void BtnAlterarContrato_Click(object sender, EventArgs e)
        {
            if(DgvContratos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                smartContratoSelecionado = DgvContratos.SelectedRows[0].DataBoundItem as SmartContrato;
                SmartContratoAlterarFrm smartContratoAlterarFrm = new SmartContratoAlterarFrm(smartContratoSelecionado);
                smartContratoAlterarFrm.MdiParent = this.MdiParent;
                smartContratoAlterarFrm.Show();
            }
        }

        private void BtnAtulizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
    }
}
