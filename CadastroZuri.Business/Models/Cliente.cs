using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroZuri.Business.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset DataNascimento { get;set; }
        public String Email { get;set; }
        public EstadoCivil EstadoCivil { get;set; }  
    }
}
