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
    public class SmartContratoNegocios
    {
        AcessoAoBancoDeDadosSqlServer acessoAoBancoDeDadosSqlServer = new AcessoAoBancoDeDadosSqlServer();

        public string InserirSmartContrato(SmartContrato smartContrato)
        {
            try
            {
                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@TipoContrato", smartContrato.TipoContrato);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@DataCriacao", smartContrato.DataCriacao);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Valor", smartContrato.Valor);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@ClienteId", smartContrato.ClienteId);

                string id = acessoAoBancoDeDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirSmartContract").ToString();
                return id;

            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string AlterarSmartContrato(SmartContrato smartContrato)
        {
            try
            {
                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@ContratoId", smartContrato.ContratoId);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@TipoContrato", smartContrato.TipoContrato);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@DataCriacao", smartContrato.DataCriacao);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Valor", smartContrato.Valor);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@ClienteId", smartContrato.ClienteId);

                string id = acessoAoBancoDeDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlterarSmartContract").ToString();
                return id;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public SmartContratoColecao ConsultaAmartContrato()
        {
            try
            {
                SmartContratoColecao smartContratosColecao = new SmartContratoColecao();
                DataTable dataTable = new DataTable();

                acessoAoBancoDeDadosSqlServer.LimparParamentros();

                dataTable = acessoAoBancoDeDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaSmartContract");

                foreach(DataRow linha in dataTable.Rows)
                {
                    SmartContrato smartContrato = new SmartContrato();

                    smartContrato.ContratoId = Convert.ToInt32(linha["ContratoId"]);
                    smartContrato.TipoContrato = Convert.ToString(linha["TipoContrato"]);
                    smartContrato.DataCriacao = Convert.ToDateTime(linha["DataCriacao"]);
                    smartContrato.Valor = Convert.ToDouble(linha["Valor"]);
                    smartContrato.ClienteId = Convert.ToInt32(linha["ClienteId"]);

                    smartContratosColecao.Add(smartContrato);
                }
                return smartContratosColecao;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public SmartContratoColecao CosultarContratoPorId(int id)
        {
            try
            {
                SmartContratoColecao smartContratosColecao = new SmartContratoColecao();
                DataTable dataTable = new DataTable();

                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@ContratoId", id);

                dataTable = acessoAoBancoDeDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaSmartContractPorId");

                foreach (DataRow linha in dataTable.Rows)
                {
                    SmartContrato smartContrato = new SmartContrato();

                    smartContrato.ContratoId = Convert.ToInt32(linha["ContratoId"]);
                    smartContrato.TipoContrato = Convert.ToString(linha["TipoContrato"]);
                    smartContrato.DataCriacao = Convert.ToDateTime(linha["DataCriacao"]);
                    smartContrato.Valor = Convert.ToDouble(linha["Valor"]);
                    smartContrato.ClienteId = Convert.ToInt32(linha["ClienteId"]);

                    smartContratosColecao.Add(smartContrato);
                }
                return smartContratosColecao;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
