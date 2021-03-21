using System.Collections.Generic;

namespace Assignment1.Data.Models
{
    public class Child : Person
    {
        public List<Interest> Interests { get; set; }
        public List<Pet> Pets { get; set; }
    }
}