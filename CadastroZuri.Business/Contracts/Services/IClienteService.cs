using CadastroZuri.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroZuri.Business.Contracts.Services
{
    public interface IClienteService
    {
        void InserirCliente(Cliente cliente);
    }
}
