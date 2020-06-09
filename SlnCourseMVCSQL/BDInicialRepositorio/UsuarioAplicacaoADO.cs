using BDProjetoDominio;
using BDProjetoDominio.Interface;
using BDProjetoRepositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace BDProjetoRepositorioADO { 
    public class UsuarioAplicacaoADO : IRepositorio<Usuario>
    {
        private DBConexao inicial;
        private void Inserir(Usuario usuario)
        {
            var strQuery = "";
            strQuery += "INSERT INTO Usuario(nome, cargo, data)";
            strQuery += string.Format(" VALUES('{0}', '{1}', '{2}')", usuario.Nome, usuario.Cargo, usuario.Data);   

            using (inicial = new DBConexao ())
            {
                inicial.ExecutaComando(strQuery);
            }
        }
        public void Alterar(Usuario usuario)
        {
            var strQuery = "";
            strQuery += "UPDATE Usuario SET ";
            strQuery += string.Format("nome = '{0}', ", usuario.Nome);
            strQuery += string.Format("cargo = '{0}', ", usuario.Cargo);
            strQuery += string.Format("data = '{0}' ", usuario.Data);
            strQuery += string.Format("WHERE Id = {0} ", usuario.Id);

            using (inicial = new DBConexao ())
            {
                inicial.ExecutaComando(strQuery);
            }
        }
        public void Salvar(Usuario usuario)
        {
            if(usuario.Id > 0)
            {
                Alterar(usuario);
            }
            else
            {
                Inserir(usuario);
            }
        }
        public void Excluir(Usuario usuario)
        {
            using (inicial = new DBConexao ())
            {
                var strQuery = string.Format("DELETE FROM Usuario WHERE Id = {0}", usuario.Id);
                inicial.ExecutaComando(strQuery);
            }
        }
        public IEnumerable<Usuario> ListarTodos()
        {
            using (inicial = new DBConexao())
            {
                var strQuery = "SELECT * FROM Usuario";
                var retorno = inicial.ExecutaComandoRetorno(strQuery);
                return ReaderEmLista(retorno);
            }
        }
        public Usuario ListarPorId(string id)
        {
            using (inicial = new DBConexao())
            {
                var strQuery = string.Format("SELECT * FROM Usuario WHERE Id = {0}", id);
                var retorno = inicial.ExecutaComandoRetorno(strQuery);
                return ReaderEmLista(retorno).FirstOrDefault();
            }
        }
        private List<Usuario>ReaderEmLista(SqlDataReader reader)
        {   
            var usuario = new List<Usuario>();
            while (reader.Read())
            {
                var tempoObjeto = new Usuario()
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    Nome = reader["nome"].ToString(),
                    Cargo = reader["cargo"].ToString(),
                    Data = DateTime.Parse(reader["data"].ToString()),
                };
                usuario.Add(tempoObjeto);
            }
            reader.Close();
            return usuario;
        }
    }
}

