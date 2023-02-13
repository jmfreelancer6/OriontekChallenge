using Domain.Core.Entity;
using Infrastructure.Data.Context;
using Infrastructure.Data.Repository;

namespace Infrastructure.Data.Persistent
{
    public class RepositoryCompania : RepositoryBase<tbl_Compania>
    {
        public RepositoryCompania(OriontekContext context) : base(context) { }
    }
}
