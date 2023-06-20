using CadastroZuri.Business.Contracts.Repositories;
using CadastroZuri.Business.Models;
using CadastroZuri.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroZuri.Repository.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ZuriDbContext _dbContext;
        public ClienteRepository(ZuriDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void InserirCliente(Cliente cliente)
        {
            _dbContext.Add(cliente);

            _dbContext.SaveChanges();
        }
    }
}
