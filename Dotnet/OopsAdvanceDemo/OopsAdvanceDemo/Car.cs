using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAdvanceDemo
{
    abstract class Car
    {
        public string brand;
        public string model;

        //public string getCarDetails()
        //{
        //    return brand + " has this " + model;
        //}

        public abstract string getCarDetails();
    }

    class BMW:Car
    {
        public string specialfeatures;
        
        public override string getCarDetails()
        {
            return this.brand + " is launched a model " + this.model + " with new feature " + this.specialfeatures;
        }
        //public string getCarDetails()
        //{
        //    Console.WriteLine(base.getCarDetails());
        //    return "Special Features: " + specialfeatures;
        //}
    }

    class Mercedes : Car
    {
        public int mileage;

        public override string getCarDetails()
        {
            return this.brand + " has launched " + this.model + " which gives mileage of " + this.mileage;
        }
    }
}
