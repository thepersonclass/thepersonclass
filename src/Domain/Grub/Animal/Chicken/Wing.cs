using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Chicken
{
    public class Wing : Food
    {
        public Wing()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 4, Polyunsaturated = 0, Saturated = 2, Monounaturated = 2 };
            Calories = 124;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0, Grams = 0 };
            Protein = 22;

            //Mg
            Cholesterol = 57;
            Sodium = 81;
            Potassium = 194;

            //Percent
            VitaminA = 1;
            Calcium = 1;
            VitaminD = 0;
            VitaminB12 = 27;
            VitaminC = 2;
            Iron = 5;
            VitaminB6 = 27;
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
