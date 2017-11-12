using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDetails.DAL
{
    public class Helper:IHelper
    {
        
        public async Task<List<IdentityTypes>> GetIdentityTypes()
        {
            using (var db = new DataContext())
            {
                return await db.IdentityTypes.ToListAsync();
            }
        }

        public async Task<Clients> Edit(int id)
        {
            using (var db = new DataContext())
            {
                return await db.Clients.FindAsync(id);
            }
        }

        public async Task<Clients> Update(Clients clients)
        {
            using (var db = new DataContext())
            {
                db.Entry(clients).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return clients;
            }
        }

    }
}
