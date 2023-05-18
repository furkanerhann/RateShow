using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Show
    {
        public int Id { get; set; }
        public string Show_Name { get; set; }
        public string Img_Url { get; set; }
        public string Genre { get; set; }
        public string Topic { get; set; }
        public string Language { get; set; }
        public string Release_Date { get; set; }
        public string Watched_Date { get; set; }
        public decimal Rate { get; set; }
    }
}
