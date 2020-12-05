using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteMakingApp.Models
{
    public class ToDoLists
    {
        public string Tittle { get; set; }
        public List<ItemTDLs> item {get;set;}
        public int id { get; set; }
        public int user_id { get; set; }
    }
}
