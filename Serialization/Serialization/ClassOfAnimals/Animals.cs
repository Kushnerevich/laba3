using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialization.ClassOfAnimals
{
    [Serializable]
    class Animals
    {
        public string Weight;
        public string Growth;
        public string TypeOfFood;
        public string ColorOfEyes;
        public string TypeOfAnimal;


        public Animals(string weight, string growth, string typeOfFood, string colorOfEyes,string typeOfAnimal)
        {
            TypeOfAnimal = typeOfAnimal;
            Weight = weight;
            Growth = growth;
            ColorOfEyes = colorOfEyes;
            TypeOfFood = typeOfFood;
        }
    }

}
