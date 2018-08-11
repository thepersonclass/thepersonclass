using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Cow
{
    public class TriTip : Food
    {
        public TriTip()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 10, Polyunsaturated = 1, Saturated = 4, Monounaturated = 5 };
            Calories = 177;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0 };
            Protein = 20;

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
