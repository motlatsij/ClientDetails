using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDetails.DAL
{
    public class Clients
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string FirstNames { get; set; }
        public int IdentityTypeId { get; set; }
        public String IdentityNumber { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}
