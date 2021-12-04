using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CompApi.DAL
{
    public class ConnectionFactory
    {
        public static string nomeConexao = "ConexaoLocal";

        public static IDbConnection GetStringConexao(IConfiguration config)
        {
            return new SqlConnection(config.GetConnectionString(nomeConexao));
        }

    }
}

