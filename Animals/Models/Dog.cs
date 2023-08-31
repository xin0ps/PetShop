﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animals.Models
{
    public class Dog : Animal
    {
        public Dog(string nickname, string gender, int age, int price, int energy, int mealquantity) :
       base(nickname, gender, age, price, energy, mealquantity)
        {

        }

       

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
            Thread.Sleep(1000);
            if (Mealquantity % 5 == 0)
            {
                Age += 1;
            }
            Energy += 10;
            Mealquantity += 1;
            Price += 2;
        }
        public override void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
            Thread.Sleep(1000);
            Energy += 5;
        }
        public override void Play()
        {
            Console.WriteLine($"{Name} is playing.");
            Thread.Sleep(1000);
            if (Energy > 0)
            {
                Energy -= 5;
            }
            else Sleep();
        }
    }
}
