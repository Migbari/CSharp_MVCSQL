using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BDProjetoDominio
{
    public class Usuario
    {
        public int Id { get; set; }
        [DisplayName("Nome Usuario")]
        [Required(ErrorMessage = "Preencha Nome do Usuário")]
        public string Nome { get; set; }
        [DisplayName("Cargo")]
        [Required(ErrorMessage = "Preencha o Cargo do Usuário")]
        public string Cargo { get; set; }
        [DisplayName("Data de Cadastro")]
        [Required(ErrorMessage = "Data de Cadastro")]
        public DateTime Data { get; set; }
    }
}
