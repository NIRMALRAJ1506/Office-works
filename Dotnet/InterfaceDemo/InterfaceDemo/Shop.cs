using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Shop : IProduct, IOutlet
    {
        public string shopName {  get; set; }
        public string pname { get ; set ; }
        public int pprice { get ; set ; }
        public string pcategory { get ; set ; }
        public string outname { get ; set ; }
        public string outcity { get ; set ; }
        public string outlocation { get ; set ; }

        public void OutletDetails()
        {
            Console.WriteLine("Shop Name: "+this.shopName);
            Console.WriteLine("Outlet Name: "+this.outname+"\n"+"Outlet City: "+this.outcity+"\n"+"Outlet Location: "+this.outlocation);
        }

        public void ProductDetails()
        {
            Console.WriteLine("Product Name: "+this.pname+"\n"+"Product Price: "+this.pprice+"\n"+"Product Category: "+this.pcategory);
        }
    }
}
