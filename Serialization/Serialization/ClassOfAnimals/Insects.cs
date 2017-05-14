using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialization.ClassOfAnimals
{
    [Serializable]
    class Insects:Animals
    {
        public string GroupOfInsects;

        public Insects(string weight, string growth, string typeOfFood, string colorOfEyes, string groupOfInsects, string typeOfAnimal)
            : base(weight, growth, typeOfFood, colorOfEyes,typeOfAnimal)
        {
            GroupOfInsects = groupOfInsects;
        }
    }
}
