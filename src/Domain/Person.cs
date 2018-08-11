using Domain.Grub.Base;
using System;

namespace Domain
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int HeightInInches { get; set; }
        public int WeightInPounds { get; set; }
        
        public void Eat(Food food)
        {

        }

        public void Drink(Beverage drink)
        {

        }
    }
}
