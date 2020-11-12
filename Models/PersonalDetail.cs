using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteMakingApp.Models
{
    public class PersonalDetail
    {
        public static List<String> categories = new List<string>(){ "Contact", "Detail" };
        public int id { get; set; }
        public int account { get; set; }
        public string content { get; set; }
        public string subcategory { get; set; }
        public string category { get; set; }
        public PersonalDetail(int acc = 0, string cat ="", string subcat = "", string cont="")
        {
            this.account = acc;
            this.content = cont;
            this.subcategory = subcat;
            this.category = cat;
        }
        public PersonalDetail() { }
    }
}
