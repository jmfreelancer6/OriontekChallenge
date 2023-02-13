using Domain.Core.Entity;
using Infrastructure.Data.Context;
using Infrastructure.Data.Repository;

namespace Infrastructure.Data.Persistent
{
    public class RepositoryClientes : RepositoryBase<tbl_Clientes>
    {
        public RepositoryClientes(OriontekContext context) : base(context) { }
    }
}
