using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteMakingApp.Models
{
    public class Person
    {
        public int id { get; set; }
        public int account { get; set; }
        public DateTime created { get; set; }
        public string name { get; set; }
        public string introduction { get; set; }

    }
}
