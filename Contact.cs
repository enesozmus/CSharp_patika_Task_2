using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_patika_Task_2
{
    class Contact                                                               // 1. adım
    {
        public Contact(string firstname, string lastname, string number)        // 2. adım
        {
            FirstName = firstname;
            LastName = lastname;
            Number = number;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
    }
}