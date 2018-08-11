using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Cow
{
    public class ShoulderPetiteTender : Food
    {
        public ShoulderPetiteTender()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 7, Polyunsaturated = 1, Saturated = 3, Monounaturated = 3 };
            Calories = 177;
            Carbohydrate = new Carbohydrate { DietaryFiber = 1, Sugar = 1 };
            Protein = 1;

            //Mg
            Cholesterol = 78;
            Sodium = 59;
            Potassium = 356;

            //Percent
            VitaminA = 0;
            Calcium = 0;
            VitaminD = 0;
            VitaminB12 = 86;
            VitaminC = 0;
            Iron = 14;
            VitaminB6 = 30;
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
