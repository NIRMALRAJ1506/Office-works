using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IAddress
    {
        string addressline1 { get; set; }
        string city {  get; set; }
        string state { get; set; }
        int postcode { get; set; }

        void AddressDetails();
    }
}
