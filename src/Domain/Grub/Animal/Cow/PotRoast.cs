using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Cow
{
    public class PotRoast : Food
    {
        public PotRoast()
        {
            //G
            Grams = 85;
            Fat = new Fat { Grams = 16, Polyunsaturated = 1, Monounaturated = 7, Saturated = 6 };
            Calories = 252;
            Carbohydrate = new Carbohydrate { Grams = 0, DietaryFiber = 0, Sugar = 0 };
            Protein = 25;

            //Mg
            Cholesterol = 99;
            Sodium = 40;
            Potassium = 196;

            //Percent
            VitaminA = 0;
            Calcium = 1;
            VitaminD = 1;
            VitaminB12 = 29;
            VitaminC = 0;
            Iron = 11;
            VitaminB6 = 10;
            Magnesium = 4;
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
