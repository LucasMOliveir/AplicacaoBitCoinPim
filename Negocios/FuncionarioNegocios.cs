using ObjetoDeTransferencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoAoBancoDeDados;
using System.Data;

namespace Negocios
{
    public class FuncionarioNegocios
    {
        AcessoAoBancoDeDadosSqlServer acessoAoBancoDeDadosSqlServer = new AcessoAoBancoDeDadosSqlServer();

        public string InserirUsuarioFuncionario(UsuarioFuncionario usuarioFuncionario)
        {
            try
            {
                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Nome", usuarioFuncionario.Nome);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@CPF", usuarioFuncionario.Cpf);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Cargo", usuarioFuncionario.Cargo);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Email", usuarioFuncionario.Email);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@DataNasc", usuarioFuncionario.DataDeNacimento);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Telefone", usuarioFuncionario.TelefoneFixo);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Celular", usuarioFuncionario.TelefoneCelular);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@EnderecoId", usuarioFuncionario.EnderecoId);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Setor", usuarioFuncionario.Setor);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Senha", usuarioFuncionario.Senha);

                string id = acessoAoBancoDeDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirFuncionario").ToString();
                return id;
            }
            catch (Exception exption)
            {
                return exption.Message;
            }
        }

        public UsuarioFuncionarioColecao ConsultarUsuarioPorNome(string nome)
        {

            try
            {
                UsuarioFuncionarioColecao usuarioFuncionariosColecao = new UsuarioFuncionarioColecao();
                DataTable dataTable = new DataTable();

                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Nome", nome);

                dataTable = acessoAoBancoDeDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarUsuarioFuncionarioPorNome");

                foreach(DataRow linha in dataTable.Rows)
                {
                    UsuarioFuncionario usuarioFuncionario = new UsuarioFuncionario();

                    usuarioFuncionario.FuncionarioId = Convert.ToInt32(linha["FuncionarioId"]);
                    usuarioFuncionario.Nome = Convert.ToString(linha["Nome"]);
                    usuarioFuncionario.Cpf = Convert.ToString(linha["CPF"]);
                    usuarioFuncionario.Cargo = Convert.ToString(linha["Cargo"]);
                    usuarioFuncionario.Email = Convert.ToString(linha["Email"]);
                    usuarioFuncionario.DataDeNacimento = Convert.ToDateTime(linha["DataNasc"]);
                    usuarioFuncionario.TelefoneFixo = Convert.ToString(linha["TelefoneFixo"]);
                    usuarioFuncionario.TelefoneCelular = Convert.ToString(linha["Celular"]);
                    usuarioFuncionario.EnderecoId = Convert.ToInt32(linha["EnderecoId"]);
                    usuarioFuncionario.Setor = Convert.ToString(linha["Setor"]);
                    usuarioFuncionario.Senha = Convert.ToString(linha["Senha"]);

                    usuarioFuncionariosColecao.Add(usuarioFuncionario);
                }

                return usuarioFuncionariosColecao;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public UsuarioFuncionarioColecao ConsultarUsuarioPorId(int id)
        {
            try
            {
                UsuarioFuncionarioColecao usuarioFuncionariosColecao = new UsuarioFuncionarioColecao();
                DataTable dataTable = new DataTable();

                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@FuncionarioId", id);

                dataTable = acessoAoBancoDeDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarUsuarioFuncionarioPorId");

                foreach (DataRow linha in dataTable.Rows)
                {
                    UsuarioFuncionario usuarioFuncionario = new UsuarioFuncionario();

                    usuarioFuncionario.FuncionarioId = Convert.ToInt32(linha["FuncionarioId"]);
                    usuarioFuncionario.Nome = Convert.ToString(linha["Nome"]);
                    usuarioFuncionario.Cpf = Convert.ToString(linha["CPF"]);
                    usuarioFuncionario.Cargo = Convert.ToString(linha["Cargo"]);
                    usuarioFuncionario.Email = Convert.ToString(linha["Email"]);
                    usuarioFuncionario.DataDeNacimento = Convert.ToDateTime(linha["DataNasc"]);
                    usuarioFuncionario.TelefoneFixo = Convert.ToString(linha["TelefoneFixo"]);
                    usuarioFuncionario.TelefoneCelular = Convert.ToString(linha["Celular"]);
                    usuarioFuncionario.EnderecoId = Convert.ToInt32(linha["EnderecoId"]);
                    usuarioFuncionario.Setor = Convert.ToString(linha["Setor"]);
                    usuarioFuncionario.Senha = Convert.ToString(linha["Senha"]);

                    usuarioFuncionariosColecao.Add(usuarioFuncionario);
                }
                return usuarioFuncionariosColecao;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string AlterarUsuario(UsuarioFuncionario usuarioFuncionario)
        {
            try
            {
                acessoAoBancoDeDadosSqlServer.LimparParamentros();
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("FuncionarioId", usuarioFuncionario.FuncionarioId);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Nome", usuarioFuncionario.Nome);
                //acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@CPF", usuarioFuncionario.Cpf);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Cargo", usuarioFuncionario.Cargo);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Email", usuarioFuncionario.Email);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@DataNasc", usuarioFuncionario.DataDeNacimento);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@TelefoneFixo", usuarioFuncionario.TelefoneFixo);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Celular", usuarioFuncionario.TelefoneCelular);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@EnderecoId", usuarioFuncionario.EnderecoId);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Setor", usuarioFuncionario.Setor);
                acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Senha", usuarioFuncionario.Senha);

                string id = acessoAoBancoDeDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlterarUsuarioFuncionario").ToString();
                return id;
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
    }
}