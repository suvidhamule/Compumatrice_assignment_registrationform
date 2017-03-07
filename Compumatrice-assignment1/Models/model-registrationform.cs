using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Compumatrice_assignment1.Models
{
    public class model_registrationform
    {

        public int id { get; private set; }

        
        public string username { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string phoneno { get; set; }
        public string location { get; set; }
    }
}