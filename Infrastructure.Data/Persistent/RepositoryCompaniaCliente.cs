using Domain.Core.Entity;
using Infrastructure.Data.Context;
using Infrastructure.Data.Repository;

namespace Infrastructure.Data.Persistent
{
    public class RepositoryCompaniaCliente : RepositoryBase<tbl_Compania_Clientes>
    {
        public RepositoryCompaniaCliente(OriontekContext context) : base(context) { }
    }
}
