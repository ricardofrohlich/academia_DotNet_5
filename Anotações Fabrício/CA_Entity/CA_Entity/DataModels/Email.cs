using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Entity.DataModels
{
    public class Email
    {
        public int id { get; set; }
        public string email { get; set; }

        public virtual Pessoa pessoa { get; set; }
    }
}
