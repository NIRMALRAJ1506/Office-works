using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IContact
    {
        public string email {  get; set; }
        public int mobile {  get; set; }

        void ContactDetails();
    }
}
