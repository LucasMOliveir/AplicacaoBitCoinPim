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
    public partial class SmartContratoAlterarFrm : Form
    {
        public SmartContratoAlterarFrm()
        {
            InitializeComponent();
        }

        SmartContratoNegocios contratoNegocios = new SmartContratoNegocios();

        public SmartContratoAlterarFrm(SmartContrato smartContrato)
        {
            InitializeComponent();

            TxtIdDoCliente.Text = smartContrato.ClienteId.ToString();
            TxtIdDoContrato.Text = smartContrato.ContratoId.ToString();
            TxtValor.Text = smartContrato.Valor.ToString();
            DtpData.Value = smartContrato.DataCriacao;
            CbxTipoDoContrato.Text = smartContrato.TipoContrato.ToString();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SmartContrato smartContrato = new SmartContrato();

            smartContrato.ClienteId = int.Parse(TxtIdDoCliente.Text);
            smartContrato.Valor = double.Parse(TxtValor.Text);
            smartContrato.DataCriacao = DtpData.Value;
            smartContrato.TipoContrato = CbxTipoDoContrato.Text;
            smartContrato.ContratoId = int.Parse(TxtIdDoContrato.Text);

            contratoNegocios.AlterarSmartContrato(smartContrato);
            this.Close();
        }
    }
}