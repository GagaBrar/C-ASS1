using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application_Ass1.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
    }
}