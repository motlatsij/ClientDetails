using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDetails.DAL
{
    public interface IHelper
    {
        Task<List<IdentityTypes>> GetIdentityTypes();
        Task<Clients> Edit(int id);
        Task<Clients> Update(Clients clients);
    }
}
