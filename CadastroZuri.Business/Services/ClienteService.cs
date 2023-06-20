using CadastroZuri.Business.Contracts.Repositories;
using CadastroZuri.Business.Contracts.Services;
using CadastroZuri.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroZuri.Business.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository= clienteRepository;  
        }

        public void InserirCliente(Cliente cliente)
        {
            _clienteRepository.InserirCliente(cliente); 
        }
    }
}
