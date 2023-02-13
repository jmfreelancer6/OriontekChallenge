using Domain.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Context
{
    public class OriontekContext : DbContext
    {
        public OriontekContext(DbContextOptions<OriontekContext> options) : base(options) { }
        public DbSet<tbl_Clientes> tbl_Clientes { get; set; }
        public DbSet<tbl_Clientes_Contacto> tbl_Clientes_Contacto { get; set; }
        public DbSet<tbl_Compania_Clientes> tbl_Compania_Clientes { get; set; }
        public DbSet<tbl_Compania> tbl_Compania { get; set; }
    }
}
