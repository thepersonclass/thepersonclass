using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Cow
{
    public class Shank : Food
    {
        public Shank()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 6, Polyunsaturated = 0, Saturated = 3, Monounaturated = 3 };
            Calories = 201;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0 };
            Protein = 34;

            //Mg
            Cholesterol = 78;
            Sodium = 64;
            Potassium = 447;

            //Percent
            VitaminA = 0;
            Calcium = 3;
            VitaminD = 0;
            VitaminB12 = 63;
            VitaminC = 0;
            Iron = 21;
            VitaminB6 = 20;
            Magnesium = 7;
        }

        public void Boil()
        {
            throw new System.NotImplementedException();
        }

        public void Broil()
        {
            Grams = 123;
        }

        public void DeepFry()
        {
            throw new System.NotImplementedException();
        }

        public void PanFry()
        {
            throw new System.NotImplementedException();
        }
    }
}
