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
