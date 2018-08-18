using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Cow
{
    public class SirloinSteak : Food
    {
        public SirloinSteak()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 14, Polyunsaturated = 1, Saturated = 6, Monounaturated = 7 };
            Calories = 244;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0 };
            Protein = 27;

            //Mg
            Cholesterol = 92;
            Sodium = 56;
            Potassium = 336;

            //Percent
            VitaminA = 0;
            Calcium = 2;
            VitaminD = 2;
            VitaminB12 = 26;
            VitaminC = 0;
            Iron = 9;
            VitaminB6 = 30;
            Magnesium = 5;
        }

        public override void Boil(IEnumerable<Ingredient> ingrediants)
        {
            throw new System.NotImplementedException();
        }

        public override void Broil(IEnumerable<Ingredient> ingrediants)
        {
            Grams = 123;
        }

        public override void DeepFry(IEnumerable<Ingredient> ingrediants)
        {
            throw new System.NotImplementedException();
        }

        public override void PanFry(IEnumerable<Ingredient> ingrediants)
        {
            throw new System.NotImplementedException();
        }
    }
}
