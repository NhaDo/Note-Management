using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteMakingApp.Models
{
    public class Reminders
    {
        public int ID { get; set; }
        public string Tittle { get; set; }
        public string Content { get; set; }
        public int Time { get; set; }
        public int Check { get; set; }
        public int User_id { get; set; }
    }
}
