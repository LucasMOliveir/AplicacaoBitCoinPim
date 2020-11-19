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
        AcessoAoBancoDeDadosSqlServer AcessoAoBancoDeDadosSqlServer = new AcessoAoBancoDeDadosSqlServer();

        public string InserirRequisicao(Requisicoes requisicoes)
        {
            try
            {
                AcessoAoBancoDeDadosSqlServer.LimparParamentros();
                AcessoAoBancoDeDadosSqlServer.AdicionarParamentros("@TipoRequisicao", requisicoes.TipoRequisicao);
                AcessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Data", requisicoes.Data);
                AcessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Valor", requisicoes.Valor);
                AcessoAoBancoDeDadosSqlServer.AdicionarParamentros("@QuantidadeDeMoedas", requisicoes.QuantidadeDeMoedas);
                AcessoAoBancoDeDadosSqlServer.AdicionarParamentros("@ClienteId", requisicoes.ClienteId);

                string id = AcessoAoBancoDeDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirRequisicao").ToString();
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
                AcessoAoBancoDeDadosSqlServer.LimparParamentros();
                AcessoAoBancoDeDadosSqlServer.AdicionarParamentros("@RequisicaoId", requisicoes.RequisisaoId);
                AcessoAoBancoDeDadosSqlServer.AdicionarParamentros("@TipoRequisicao", requisicoes.TipoRequisicao);
                AcessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Data", requisicoes.Data);
                AcessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Valor", requisicoes.Valor);
                AcessoAoBancoDeDadosSqlServer.AdicionarParamentros("@QuantidadeDeMoedas", requisicoes.QuantidadeDeMoedas);
                AcessoAoBancoDeDadosSqlServer.AdicionarParamentros("@ClienteId", requisicoes.ClienteId);

                string Id = AcessoAoBancoDeDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlterarRequisicao").ToString();
                return Id;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
