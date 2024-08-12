using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IProduct
    {
        public string pname {  get; set; }
        public int pprice {  get; set; }
        public string pcategory {  get; set; }

        void ProductDetails();
    }
}
