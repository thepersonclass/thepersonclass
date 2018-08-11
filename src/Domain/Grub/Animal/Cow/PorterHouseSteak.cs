using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Cow
{
    public class PorterHouseSteak : Food
    {
        public PorterHouseSteak()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 15, Polyunsaturated = 1, Saturated = 7, Monounaturated = 7 };
            Calories = 220;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0 };
            Protein = 19;

            //Mg
            Cholesterol = 57;
            Sodium = 54;
            Potassium = 311;

            //Percent
            VitaminA = 0;
            Calcium = 0;
            VitaminD = 0;
            VitaminB12 = 46;
            VitaminC = 0;
            Iron = 11;
            VitaminB6 = 20;
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
