using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IShape
    {
        public int side {  get; set; }
        public int length {  get; set; }
        public int breadth {  get; set; }
        public void Draw();
    }
}
