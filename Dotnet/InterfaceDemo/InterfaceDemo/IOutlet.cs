using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IOutlet
    {
        public string outname {  get; set; }
        public string outcity {  get; set; }
        public string outlocation {  get; set; }

        void OutletDetails();
    }
}
