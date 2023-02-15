using Domain.Core.Contracts;
using Domain.Core.Entity;
using Infrastructure.Data.Context;
using Infrastructure.Data.Persistent;

namespace Infrastructure.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly OriontekContext _context;
        public UnitOfWork(OriontekContext context)
        {
            _context = context;
        }
        public IRepository<tbl_Compania> CompaniaRepository => new RepositoryCompania(_context);

        public IRepository<tbl_Clientes> ClienteRepository => new RepositoryClientes(_context);

        public IValidatorRepository<tbl_Clientes_Contacto>  ClienteContactoRepository => new RepositoryClientesContacto(_context);

        public IRepository<tbl_Compania_Clientes> CompaniaClienteRepository => new RepositoryCompaniaCliente(_context);

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
