using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Cow
{
    public class TenderlionSteak : Food
    {
        public TenderlionSteak()
        {
            Grams = 1;
            Fat = new Fat { Grams = 1, Polyunsaturated = 1, Saturated = 1 };
            Calories = 1;
            Cholesterol = 1;
            Sodium = 1;
            Potassium = 1;
            Carbohydrate = new Carbohydrate { DietaryFiber = 1, Sugar = 1 };
            Protein = 1;
            VitaminA = 1;
            Calcium = 1;
            VitaminD = 1;
            VitaminB12 = 1;
            VitaminC = 1;
            Iron = 1;
            VitaminB6 = 1;
            Magnesium = 1;
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
