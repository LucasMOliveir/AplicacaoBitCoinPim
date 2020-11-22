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
    public partial class RequisicoesAlterarFrm : Form
    {
        public RequisicoesAlterarFrm()
        {
            InitializeComponent();
        }

        public RequisicoesAlterarFrm(Requisicoes requisicoes)
        {
            InitializeComponent();

            TxtIdDaRequisicao.Text = requisicoes.RequisicaoId.ToString();
            TxtIdDoCliente.Text = requisicoes.ClienteId.ToString();
            TxtQuantidadeDeMoedas.Text = requisicoes.QuantidadeDeMoedas.ToString();
            TxtTipoDaRequisicao.Text = requisicoes.TipoRequisicao.ToString();
            TxtValor.Text = requisicoes.Valor.ToString();
            DtpData.Value = requisicoes.Data;
        }

        
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Requisicoes requisicoes = new Requisicoes();
            RequisicoesNegocios requisicoesNegocios = new RequisicoesNegocios();

            requisicoes.ClienteId = int.Parse(TxtIdDoCliente.Text);
            requisicoes.Data = DtpData.Value;
            requisicoes.QuantidadeDeMoedas = double.Parse(TxtQuantidadeDeMoedas.Text);
            requisicoes.RequisicaoId = int.Parse(TxtIdDaRequisicao.Text);
            requisicoes.TipoRequisicao = TxtTipoDaRequisicao.Text;
            requisicoes.Valor = double.Parse(TxtValor.Text);

            requisicoesNegocios.AlterarRequisicao(requisicoes);
            this.Close();
        }
    }
}
