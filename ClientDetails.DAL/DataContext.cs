using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDetails.DAL
{
    public class DataContext: DbContext
    {
        public DataContext()
        : base("ClientDetails")
        {
        }
        public DbSet<IdentityTypes> IdentityTypes { get; set; }
        public DbSet<Clients> Clients { get; set; }
    }
}
