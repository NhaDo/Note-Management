using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteMakingApp.Models
{
    public class Account
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime created { get; set; }
        public int creator { get; set; }
    }
}
