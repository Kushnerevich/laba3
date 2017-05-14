using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialization.ClassOfAnimals
{
    [Serializable]
    class Mammals:Animals
    {
        public string Hairline;

        public Mammals(string weight, string growth, string typeOfFood, string colorOfEyes, string hairline, string typeOfAnimal)
            : base(weight, growth, typeOfFood, colorOfEyes,typeOfAnimal)
        {
            Hairline = hairline;
        }
    }
}
