using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Bootgrid_example.Models
{
    public class Contact
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string birthday { get; set; }
        public bool isSelected { get; set; }
    }
}