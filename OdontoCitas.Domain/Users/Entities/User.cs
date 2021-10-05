using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCitas.Domain.Users.Entities
{
    public class User
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
    }
}
