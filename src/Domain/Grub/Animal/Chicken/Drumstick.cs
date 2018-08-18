using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Chicken
{
    public class Drumstick : Food
    {
        public Drumstick()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 9, Polyunsaturated = 2, Saturated = 3, Monounaturated = 4 };
            Calories = 160;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0, Grams = 0 };
            Protein = 19;

            //Mg
            Cholesterol = 181;
            Sodium = 83;
            Potassium = 206;

            //Percent
            VitaminA = 2;
            Calcium = 1;
            VitaminD = 0;
            VitaminB12 = 6;
            VitaminC = 5;
            Iron = 6;
            VitaminB6 = 15;
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
