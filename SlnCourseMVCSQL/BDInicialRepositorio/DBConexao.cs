using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BDProjetoRepositorio
{
    public class DBConexao : IDisposable
    {
        private readonly SqlConnection conexao;
        public DBConexao()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["CnxConexao"].ConnectionString);
            conexao.Open();
        }
        public void ExecutaComando(string strQuery)
        {
            var cmdComando = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = conexao
            };
            cmdComando.ExecuteNonQuery();
        }
        public SqlDataReader ExecutaComandoRetorno(string strQuery)
        {
            var cmdComandoSelect = new SqlCommand(strQuery, conexao);
            return cmdComandoSelect.ExecuteReader();
        }
        public void Dispose()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
