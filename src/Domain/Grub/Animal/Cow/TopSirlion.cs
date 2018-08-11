using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Cow
{
    public class TopSirlion : Food
    {
        public TopSirlion()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 11, Polyunsaturated = 1, Saturated = 5, Monounaturated = 5 };
            Calories = 213;
            Carbohydrate = new Carbohydrate { DietaryFiber = 1, Sugar = 1 };
            Protein = 1;

            //Mg
            Cholesterol = 85;
            Sodium = 84;
            Potassium = 369;

            //Percent
            VitaminA = 0;
            Calcium = 0;
            VitaminD = 1;
            VitaminB12 = 76;
            VitaminC = 0;
            Iron = 18;
            VitaminB6 = 20;
            Magnesium = 6;
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
