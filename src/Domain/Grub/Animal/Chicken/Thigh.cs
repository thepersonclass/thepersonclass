using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Chicken
{
    public class Thigh : Food
    {
        public Thigh()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 8, Polyunsaturated = 2, Saturated = 2, Monounaturated = 4 };
            Calories = 177;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0, Grams = 0 };
            Protein = 24;

            //Mg
            Cholesterol = 135;
            Sodium = 87;
            Potassium = 277;

            //Percent
            VitaminA = 0;
            Calcium = 1;
            VitaminD = 1;
            VitaminB12 = 6;
            VitaminC = 0;
            Iron = 6;
            VitaminB6 = 25;
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
