using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespaces que são necessarios para manipulação dos dados do banco
using System.Data;
using System.Data.SqlClient;
using AcessoAoBancoDeDados.Properties;

namespace AcessoAoBancoDeDados
{
    public class AcessoAoBancoDeDadosSqlServer
    {
        //Cria a conexão com o banco com base da string de conexão das configurações (Settings)
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.stringDeConecao);
        }

        //Parametros que vão para o banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        //Metodo que limpa os parametros usados no banco
        public void LimparParamentros()
        {
            sqlParameterCollection.Clear();
        }

        //Cria os paramentros para o trafego de informações
        public void AdicionarParamentros(string nomeDoParamentro, object valorDoParamentro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeDoParamentro, valorDoParamentro));
        }

        //Metodo necessario para a persistencia no banco de deados
        public object ExecutarManipulacao(CommandType commandType, string nomeDaStoredProcedureOuTextoSql)
        {

            try
            {
                //Cria a conexao
                SqlConnection sqlConnection = CriarConexao();
                //Abre a conexão
                sqlConnection.Open();

                //Cria o comando para o transporte de dados
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                //Colocando os dados dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeDaStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 180;// Tempo em segundos

                //Adicionar os paramentros do banco de dados
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Executando o comando e retorna o resultado que o banco de dados mandou
                return sqlCommand.ExecuteScalar();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar registro(s) do banco de dados
        public DataTable ExecutarConsulta(CommandType commandType, string nomeDaStoredProcedureOuTextoSql)
        {
            try
            {
                //Cria a conexao
                SqlConnection sqlConnection = CriarConexao();
                //Abre a conexão
                sqlConnection.Open();

                //Cria o comando para o transporte de dados
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                //Colocando os dados dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeDaStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 180;// Tempo em segundos

                //Adicionar os paramentros do banco de dados
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                // Criar adaptador, ele "traduz" as informações do banco para c#
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //DataTable é a tabela de dados que vai guardar as iformações do sqlDataAdapter
                DataTable dataTable = new DataTable();

                //Comando busca no banco os dados e o sqlDataAdapter preenche a dataTable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
