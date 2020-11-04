using AcessoAoBancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetoDeTransferencia;
using System.ComponentModel;
using Microsoft.Win32;
using System.Data;

namespace Negocios
{
    public class EnderecoNegocios
    {
        AcessoAoBancoDeDadosSqlServer acessoAoBancoDeDadosSqlServer = new AcessoAoBancoDeDadosSqlServer();
        
        public string InserirEndereco(Endereco endereco)
        {
            try
            {
                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Logradouro", endereco.Logradouro);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Numero",endereco.Numero);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Bairro",endereco.Bairro);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Cidade",endereco.Cidade);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Estado",endereco.UF);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Pais",endereco.Pais);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Complemento",endereco.Complemento);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Cep",endereco.Cep);

                string Id = acessoAoBancoDeDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirEndereco").ToString();
                return Id;

            }
            catch (Exception exeption)
            {
                return exeption.Message;
            }
        }

        public string AlterarEndereco(Endereco endereco)
        {
            try
            {
                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@EnderecoId", endereco.EnderecoId);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Logradouro", endereco.Logradouro);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Numero", endereco.Numero);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Bairro", endereco.Bairro);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Cidade", endereco.Cidade);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Estado", endereco.UF);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Pais", endereco.Pais);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Cep", endereco.Cep);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Complemento", endereco.Complemento);

                string Id = acessoAoBancoDeDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlterarEndereco").ToString();
                return Id;

            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }

        public EnderecoColecao ConsultarEndrecoId (int Id)
        {
            try
            {
                EnderecoColecao endrecoColecao = new EnderecoColecao();
                DataTable dataTable = new DataTable();

                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@EnderecoId", Id);

                dataTable = acessoAoBancoDeDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarIdEndereco");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Endereco endereco = new Endereco();

                    endereco.EnderecoId = Convert.ToInt32(linha["EnderecoId"]);
                    endereco.Logradouro = Convert.ToString(linha["Logradouro"]);
                    endereco.Numero = Convert.ToString(linha["Numero"]);
                    endereco.Bairro = Convert.ToString(linha["Bairro"]);
                    endereco.Cidade = Convert.ToString(linha["Cidade"]);
                    endereco.UF = Convert.ToString(linha["Estado"]);
                    endereco.Pais = Convert.ToString(linha["Pais"]);
                    endereco.Cep = Convert.ToString(linha["Cep"]);
                    endereco.Complemento = Convert.ToString(linha["Complemento"]);

                    endrecoColecao.Add(endereco);
                }
                return endrecoColecao;
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public EnderecoColecao ConsultarEndrecoCep(string cep)
        {
            try
            {
                EnderecoColecao endrecoColecao = new EnderecoColecao();
                DataTable dataTable = new DataTable();

                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Cep", cep);

                dataTable = acessoAoBancoDeDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaCepEndereco");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Endereco endereco = new Endereco();

                    endereco.EnderecoId = Convert.ToInt32(linha["EnderecoId"]);
                    endereco.Logradouro = Convert.ToString(linha["Logradouro"]);
                    endereco.Numero = Convert.ToString(linha["Numero"]);
                    endereco.Bairro = Convert.ToString(linha["Bairro"]);
                    endereco.Cidade = Convert.ToString(linha["Cidade"]);
                    endereco.UF = Convert.ToString(linha["Estado"]);
                    endereco.Pais = Convert.ToString(linha["Pais"]);
                    endereco.Cep = Convert.ToString(linha["Cep"]);
                    endereco.Complemento = Convert.ToString(linha["Complemento"]);

                    endrecoColecao.Add(endereco);

                    
                }
                return endrecoColecao;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
