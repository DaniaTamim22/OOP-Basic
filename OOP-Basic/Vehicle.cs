using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP_Basic
{
    internal interface IDrivable
    {
        string Drive(int distance);

    }
    internal interface IStopable
    {
        public void Stop();
    }


    internal class Vehicle : IDrivable
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public string Drive(int distance)
        {
            return $"{GetType().Name}Vehicle drove for {distance}";
        }
    }


    internal class Car : Vehicle, IStopable
    {
        public string Model { get; set; }
        public Car(string brand, string model) : base(brand)
        {
            Model = model;
        }

        public void Stop()
        {
            // Do Somthing
        }
    }



    internal class Saab : Car
    {
        public Saab(string model = "93") : base("Saab", model)
        {


        }
        public string SaabSpecialMethod()
        {
            return "From Saab";
        }
    }
}
