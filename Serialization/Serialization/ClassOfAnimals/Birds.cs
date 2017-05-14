using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialization.ClassOfAnimals
{
    [Serializable]
    class Birds:Animals
    {
        public string ColorOfPlumage;

        public Birds(string weight, string growth, string typeOfFood, string colorOfEyes, string colorOfPlumage, string typeOfAnimal): base(weight, growth, typeOfFood, colorOfEyes,typeOfAnimal)
        {
            ColorOfPlumage = colorOfPlumage;
        }
    }
}
