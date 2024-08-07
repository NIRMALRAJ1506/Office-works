using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprogramming
{
    internal class Mathoperations
    {
        private int num1;
        private int num2;

        public Mathoperations(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        private int add(int x, int y)
        {
            int result=x+y;
            return result;
        }
        private int sub(int x, int y)
        {
            int result = x - y;
            return result;
        }
        private int mul(int x, int y)
        {
            int result = x * y;
            return result;
        }
        private int div(int x, int y)
        {
            int result = x / y;
            return result;
        }

        public void Displayoperations()
        {
            Console.WriteLine("Add: "+ add(this.num1,this.num2));
            Console.WriteLine("Sub: " + sub(this.num1, this.num2));
            Console.WriteLine("Mul: " + mul(this.num1, this.num2));
            Console.WriteLine("Div: " + div(this.num1, this.num2));
        }

    }
}
