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

        public void AdicionarParamentros(string nomeDoParamentro, object valorDoParamentro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeDoParamentro, valorDoParamentro));
        }

    }
}
