using BDProjetoAplicacao;
using BDProjetoDominio;
using System;

namespace ConsoleMVCSQL
{
    public class Program
    {
        static void Main(string[] args)
        {
            var usuarioAplicacao = new UsuarioAplicacao();
           
             Console.WriteLine("Digite o nome do usuário: ");
             string nome = Console.ReadLine();

             Console.WriteLine("Digite o cargo do usuário: ");
             string cargo = Console.ReadLine();

             Console.WriteLine("Digite a data de cadastro do usuário: ");
             string data = Console.ReadLine();

             var usuario = new Usuario
             {
                 Nome = nome,
                 Cargo = cargo,
                 Data = DateTime.Parse(data)
             };

             //usuario.Id = 5;
             usuarioAplicacao.Salvar(usuario);

            //usuarioAplicacao.Excluir(1004);
            var dados = usuarioAplicacao.ListarTodos();
         
            foreach(var usuarios in dados)
            {
                Console.WriteLine("Id:{0}, Nome Usuário: {1}, Cargo: {2}, Data Cadastro: {3}", usuarios.Id, usuarios.Nome, usuarios.Cargo, usuarios.Data);
            }
            Console.ReadKey();
        }
    }
}
