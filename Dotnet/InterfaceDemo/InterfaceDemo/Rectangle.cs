using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Rectangle : IShape
    {
        public int length { get; set; }
        public int breadth {  get; set; }
        public int side { get; set; }

        public void Draw()
        {
            int area = length * breadth;
            Console.WriteLine("Area of the Rectangle is: "+area);
        }
    }
}
