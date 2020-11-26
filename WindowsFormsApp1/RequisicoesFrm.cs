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
    public partial class RequisicoesFrm : Form
    {
        public RequisicoesFrm()
        {
            InitializeComponent();
            Atualizar();
        }

        public void Atualizar()
        {
            RequisicaoColecao requisicoesColecao = new RequisicaoColecao();
            RequisicoesNegocios requisicoesNegocios = new RequisicoesNegocios();

            requisicoesColecao = requisicoesNegocios.ConsultaRequisicoes();
            DgvRequisicoes.DataSource = null;
            DgvRequisicoes.DataSource = requisicoesNegocios.ConsultaRequisicoes();

            DgvRequisicoes.Update();
            DgvRequisicoes.Refresh();
        }

        private void BtnInserirRequisicao_Click(object sender, EventArgs e)
        {
            RequisicoesInserirFrm requisicoesInserirFrm = new RequisicoesInserirFrm();
            requisicoesInserirFrm.MdiParent = this.MdiParent;
            requisicoesInserirFrm.Show();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (DgvRequisicoes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Requisicoes requisicoesSelecionadas = new Requisicoes();
                requisicoesSelecionadas = DgvRequisicoes.SelectedRows[0].DataBoundItem as Requisicoes;
                RequisicoesAlterarFrm requisicoesAlterarFrm = new RequisicoesAlterarFrm(requisicoesSelecionadas);
                requisicoesAlterarFrm.MdiParent = this.MdiParent;
                requisicoesAlterarFrm.Show();
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void BtnPesquisarId_Click(object sender, EventArgs e)
        {
            RequisicaoColecao requisicoesColecao = new RequisicaoColecao();
            RequisicoesNegocios requisicoesNegocios = new RequisicoesNegocios();

            requisicoesColecao = requisicoesNegocios.ConsultarRequisicaoPorId(Convert.ToInt32(TxtIdRequisicao.Text));
            DgvRequisicoes.DataSource = null;
            DgvRequisicoes.DataSource = requisicoesColecao;

            DgvRequisicoes.Update();
            DgvRequisicoes.Refresh();
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            RequisicaoRelatorio requisicaoRelatorio = new RequisicaoRelatorio();
            requisicaoRelatorio.MdiParent = this.MdiParent;
            requisicaoRelatorio.Show();
        }
    }
}
