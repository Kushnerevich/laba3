using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialization.ClassOfAnimals
{
    [Serializable]
    class Reptiles:Animals
    {
        public string Sex;

        public Reptiles(string weight, string growth, string typeOfFood, string colorOfEyes, string sex, string typeOfAnimal)
            : base(weight, growth,typeOfFood, colorOfEyes,typeOfAnimal)
        {
            Sex = sex;
        }
    }
}
