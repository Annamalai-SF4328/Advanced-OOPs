using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface1
{
    public class Dog : IAnimal
    {
        // property
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }
        // constructor
        public Dog(string name,string habitat,string eatingHabit)
        {
            Name=name;
            Habitat=habitat;
            EatingHabit=eatingHabit;
        }
        // mathod
        public string DisplayName()
        {
            return Name;
        }
    }
}