using Domain.Grub.Base;
using System.Collections.Generic;

namespace Domain.Grub.Animal.Chicken
{
    public class Breast : Food
    {
        public Breast()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 4, Polyunsaturated = 1, Saturated = 1, Monounaturated = 2 };
            Calories = 165;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0, Grams = 0 };
            Protein = 31;

            //Mg
            Cholesterol = 85;
            Sodium = 74;
            Potassium = 256;

            //Percent
            VitaminA = 0;
            Calcium = 1;
            VitaminD = 1;
            VitaminB12 = 5;
            VitaminC = 0;
            Iron = 5;
            VitaminB6 = 30;
            Magnesium = 7;
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
