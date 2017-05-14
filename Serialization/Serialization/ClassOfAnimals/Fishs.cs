using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialization.ClassOfAnimals
{
    [Serializable]
    class Fishs:Animals
    {
        public string ColorOfScales;

        public Fishs(string weight, string growth, string typeOfFood, string colorOfEyes, string colorOfsScales, string typeOfAnimal): base(weight, growth, typeOfFood, colorOfEyes, typeOfAnimal)
        {
            ColorOfScales = colorOfsScales;
        }
    }
}
