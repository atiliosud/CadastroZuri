using CadastroZuri.Business.Models;
using System.ComponentModel.DataAnnotations;

namespace CadastroZuri.Api.ViewModel
{
    public class ClienteVM
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public EstadoCivil EstadoCivil { get; set; }

        internal Cliente MapperToModel()
        {
            return new Cliente()
            {
                Name = this.Nome,
                DataNascimento = this.DataNascimento,
                Email = this.Email,
                EstadoCivil= this.EstadoCivil
            };
        }
    }
}
