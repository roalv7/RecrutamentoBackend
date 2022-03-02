using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutamentoBackend.Database.Entities
{
    public class Users
    {
        public string name { get; set; }
        public string email { get; set; }

        public string number { get; set; }

        public string interests { get; set; }

        public string message { get; set; }
    }
}
