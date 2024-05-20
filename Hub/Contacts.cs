using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneAppV2
{
    internal class Contacts
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string description { get; set; }
        //adding id for the contacts
        public int id { get; set; }
    }
}
