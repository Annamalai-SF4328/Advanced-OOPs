using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface1
{
    public interface IAnimal
    {
        // property
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }
        // method
        string DisplayName();
    }
}