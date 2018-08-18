using Domain.Grub.Base;
using System.Collections.Generic;

namespace Domain.Grub.Animal.Cow
{
    public class BladeSteak : Food
    {
        public BladeSteak()
        {
            //G
            Grams = 199;
            Fat = new Fat { Grams = 18, Polyunsaturated = 2, Saturated = 8, Monounaturated = 8 };
            Calories = 387;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0, Grams = 0 };
            Protein = 55;

            //Mg
            Cholesterol = 195;
            Sodium = 175;
            Potassium = 722;

            //Percent
            VitaminA = 0;
            Calcium = 2;
            VitaminD = 2;
            VitaminB12 = 175;
            VitaminC = 0;
            Iron = 33;
            VitaminB6 = 40;
            Magnesium = 12;
        }
    }
}
