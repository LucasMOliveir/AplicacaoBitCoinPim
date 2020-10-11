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
    public class LogInNegocio
    {

        AcessoAoBancoDeDadosSqlServer acessoAoBancoDeDadosSqlServer = new AcessoAoBancoDeDadosSqlServer();

        public string ValidarLogIn(UsuarioFuncionario usuarioFuncionario)
        {
            acessoAoBancoDeDadosSqlServer.LimparParamentros();
            acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@FuncionárioId", usuarioFuncionario.FuncionarioId);
            acessoAoBancoDeDadosSqlServer.AdicionarParamentros("@Senha", usuarioFuncionario.Senha);
            return acessoAoBancoDeDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "NomeProcedure").ToString();
        }

    }
}
