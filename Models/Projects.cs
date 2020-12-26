using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteMakingApp.Models
{
    public class Projects
    {
        public string Tittle { get; set; }
        public List<ItemProjects> item { get; set; }
        public int id { get; set; }
        public int user_id { get; set; }
        public string deadline { get; set; }
    }
}
