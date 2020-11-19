using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoAoBancoDeDados;
using ObjetoDeTransferencia;

namespace Negocios
{
    public class UsuarioClienteNegocios
    {

        AcessoAoBancoDeDadosSqlServer acessoAoBancoDeDadosSqlServer = new AcessoAoBancoDeDadosSqlServer();
        
        public string InserirUsuarioCliente(UsuarioCliente usuarioCliente)
        {
            try
            {
                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Nome", usuarioCliente.Nome);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@CPF", usuarioCliente.CPF);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Email", usuarioCliente.Email);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@DataNasc", usuarioCliente.DataDeNascimento);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Senha", usuarioCliente.Senha);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@TelefoneFixo", usuarioCliente.TelefoneFixo);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Celular", usuarioCliente.Celular);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@EnderecoId", usuarioCliente.EnderecoId);

                string id = acessoAoBancoDeDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirUsuarioCliente").ToString();
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string AlterarCliente(UsuarioCliente usuarioCliente)
        {
            try
            {
                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@ClienteId", usuarioCliente.ClienteId);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Nome", usuarioCliente.Nome);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@CPF", usuarioCliente.CPF);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Email", usuarioCliente.Email);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@DataNasc", usuarioCliente.DataDeNascimento);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Senha", usuarioCliente.Senha);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@TelefoneFixo", usuarioCliente.TelefoneFixo);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Celular", usuarioCliente.Celular);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@EnderecoId", usuarioCliente.EnderecoId);

                string id = acessoAoBancoDeDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlterarUsuarioCliente").ToString();
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UsuarioClienteColecao ConsultarClientePorId(int id)
        {
            try
            {
                DataTable dataTable = new DataTable();
                UsuarioClienteColecao usuarioClientesColecao = new UsuarioClienteColecao();

                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@ClienteId", id);

                dataTable = acessoAoBancoDeDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarCliendeId");

                foreach (DataRow linha in dataTable.Rows)
                {
                    UsuarioCliente usuarioCliente = new UsuarioCliente();

                    usuarioCliente.ClienteId = Convert.ToInt32(linha["ClienteId"]);
                    usuarioCliente.Nome = Convert.ToString(linha["Nome"]);
                    usuarioCliente.CPF = Convert.ToString(linha["CPF"]);
                    usuarioCliente.Email = Convert.ToString(linha["Email"]);
                    usuarioCliente.DataDeNascimento = Convert.ToDateTime(linha["DataNasc"]);
                    usuarioCliente.Senha = Convert.ToString(linha["Senha"]);
                    usuarioCliente.TelefoneFixo = Convert.ToString(linha["TelefoneFixo"]);
                    usuarioCliente.Celular = Convert.ToString(linha["Celular"]);
                    usuarioCliente.EnderecoId = Convert.ToInt32(linha["EnderecoId"]);

                    usuarioClientesColecao.Add(usuarioCliente);
                }

                return usuarioClientesColecao;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public UsuarioClienteColecao ConsultarClientePorNome(string nome)
        {
            try
            {
                UsuarioClienteColecao usuarioClientesColecao = new UsuarioClienteColecao();
                DataTable dataTable = new DataTable();

                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Nome", nome);

                dataTable = acessoAoBancoDeDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCunsultarClienteNome");

                foreach (DataRow linha in dataTable.Rows)
                {
                    UsuarioCliente usuarioCliente = new UsuarioCliente();

                    usuarioCliente.ClienteId = Convert.ToInt32(linha["ClienteId"]);
                    usuarioCliente.Nome = Convert.ToString(linha["Nome"]);
                    usuarioCliente.CPF = Convert.ToString(linha["CPF"]);
                    usuarioCliente.Email = Convert.ToString(linha["Email"]);
                    usuarioCliente.DataDeNascimento = Convert.ToDateTime(linha["DataNasc"]);
                    usuarioCliente.Senha = Convert.ToString(linha["Senha"]);
                    usuarioCliente.TelefoneFixo = Convert.ToString(linha["TelefoneFixo"]);
                    usuarioCliente.Celular = Convert.ToString(linha["Celular"]);
                    usuarioCliente.EnderecoId = Convert.ToInt32(linha["EnderecoId"]);

                    usuarioClientesColecao.Add(usuarioCliente);
                }

                return usuarioClientesColecao;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
