using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Cow
{
    public class FlankSteak : Food
    {
        public FlankSteak()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 8, Polyunsaturated = 0, Saturated = 4, Monounaturated = 4 };
            Calories = 192;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0 };
            Protein = 28;

            //Mg
            Cholesterol = 79;
            Sodium = 56;
            Potassium = 339;

            //Percent
            VitaminA = 0;
            Calcium = 2;
            VitaminD = 0;
            VitaminB12 = 26;
            VitaminC = 0;
            Iron = 9;
            VitaminB6 = 30;
            Magnesium = 5;
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
