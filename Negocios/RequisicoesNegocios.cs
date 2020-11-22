using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetoDeTransferencia;
using AcessoAoBancoDeDados;
using System.Data;

namespace Negocios
{
    public class RequisicoesNegocios
    {
        AcessoAoBancoDeDadosSqlServer acessoAoBancoDeDadosSqlServer = new AcessoAoBancoDeDadosSqlServer();

        public string InserirRequisicao(Requisicoes requisicoes)
        {
            try
            {
                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@TipoRequisicao", requisicoes.TipoRequisicao);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Data", requisicoes.Data);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Valor", requisicoes.Valor);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@QuantidadeDeMoedas", requisicoes.QuantidadeDeMoedas);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@ClienteId", requisicoes.ClienteId);

                string id = acessoAoBancoDeDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirRequisicao").ToString();
                return id;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AlterarRequisicao(Requisicoes requisicoes)
        {
            try
            {
                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@RequisicaoId", requisicoes.RequisicaoId);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@TipoRequisicao", requisicoes.TipoRequisicao);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Data", requisicoes.Data);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Valor", requisicoes.Valor);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@QuantidadeDeMoedas", requisicoes.QuantidadeDeMoedas);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@ClienteId", requisicoes.ClienteId);

                string Id = acessoAoBancoDeDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlterarRequisicao").ToString();
                return Id;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public RequisicaoColecao ConsultarRequisicaoPorId(int id)
        {
            try
            {
                RequisicaoColecao requisicaoColecao = new RequisicaoColecao();
                DataTable dataTable = new DataTable();

                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@RequisicaoId", id);

                dataTable = acessoAoBancoDeDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarRequisicaoPorId");

                foreach(DataRow linha in dataTable.Rows)
                {
                    Requisicoes requisicoes = new Requisicoes();

                    requisicoes.RequisicaoId = Convert.ToInt32(linha["RequisicaoId"]);
                    requisicoes.TipoRequisicao = Convert.ToString(linha["TipoRequisicao"]);
                    requisicoes.Data = Convert.ToDateTime(linha["Data"]);
                    requisicoes.Valor = Convert.ToDouble(linha["Valor"]);
                    requisicoes.QuantidadeDeMoedas = Convert.ToDouble(linha["QuantidadeDeMoedas"]);
                    requisicoes.ClienteId = Convert.ToInt32(linha["ClienteId"]);

                    requisicaoColecao.Add(requisicoes);
                }
                return requisicaoColecao;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public RequisicaoColecao ConsultaRequisicoes()
        {
            try
            {
                RequisicaoColecao requisicaoColecao = new RequisicaoColecao();
                DataTable dataTable = new DataTable();

                acessoAoBancoDeDadosSqlServer.LimparParamentros();

                dataTable = acessoAoBancoDeDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarRequisicao");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Requisicoes requisicoes = new Requisicoes();

                    requisicoes.RequisicaoId = Convert.ToInt32(linha["RequisicaoId"]);
                    requisicoes.TipoRequisicao = Convert.ToString(linha["TipoRequisicao"]);
                    requisicoes.Data = Convert.ToDateTime(linha["Data"]);
                    requisicoes.Valor = Convert.ToDouble(linha["Valor"]);
                    requisicoes.QuantidadeDeMoedas = Convert.ToDouble(linha["QuantidadeDeMoedas"]);
                    requisicoes.ClienteId = Convert.ToInt32(linha["ClienteId"]);

                    requisicaoColecao.Add(requisicoes);
                }
                return requisicaoColecao;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
