using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Square : IShape
    {
        public int side { get; set; }

        public int length { get; set; }
        public int breadth { get; set; }
        

        public void Draw()
        {
            int area = side * side;
            Console.WriteLine("Area of a Square is: "+area);
        }
    }
}
