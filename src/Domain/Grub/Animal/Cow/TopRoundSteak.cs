using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Cow
{
    public class TopRoundSteak : Food
    {
        public TopRoundSteak()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 8, Polyunsaturated = 1, Saturated = 3, Monounaturated = 4 };
            Calories = 166;
            Carbohydrate = new Carbohydrate { DietaryFiber = 1, Sugar = 1 };
            Protein = 1;

            //Mg
            Cholesterol = 69;
            Sodium = 60;
            Potassium = 349;

            //Percent
            VitaminA = 0;
            Calcium = 2;
            VitaminD = 0;
            VitaminB12 = 26;
            VitaminC = 0;
            Iron = 10;
            VitaminB6 = 35;
            Magnesium = 6;
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
