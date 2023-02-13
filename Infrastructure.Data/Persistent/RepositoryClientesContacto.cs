using Domain.Core.Constract;
using Domain.Core.Entity;
using Infrastructure.Data.Context;
using Infrastructure.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Persistent
{
    public class RepositoryClientesContacto : RepositoryBase<tbl_Clientes_Contacto>, IValidatorRepository<tbl_Clientes_Contacto>
    {
        public RepositoryClientesContacto(OriontekContext context) : base(context) { }

        public async Task<bool> ValidateIfExist(int id)
        {
            return await _context.tbl_Clientes.AnyAsync(a => a.ID == id);
        }
    }
}
