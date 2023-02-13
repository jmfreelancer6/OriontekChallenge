using Domain.Core.Entity;

namespace Domain.Core.Constract
{
    public interface IUnitOfWork
    {
        public IRepository<tbl_Compania> CompaniaRepository { get; }
        public IRepository<tbl_Clientes> ClienteRepository { get; }
        public IValidatorRepository<tbl_Clientes_Contacto> ClienteContactoRepository { get; }
        public IRepository<tbl_Compania_Clientes> CompaniaClienteRepository { get; }
    }
}
