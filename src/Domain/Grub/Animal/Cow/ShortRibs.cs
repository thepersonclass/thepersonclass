using Domain.Grub.Base;
using System.Collections.Generic;

namespace Domain.Grub.Animal.Cow
{
    public class ShortRibs : Food
    {
        public ShortRibs()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 42, Polyunsaturated = 2, Saturated = 19, Monounaturated = 21 };
            Calories = 471;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0 };
            Protein = 22;

            //Mg
            Cholesterol = 94;
            Sodium = 50;
            Potassium = 224;

            //Percent
            VitaminA = 0;
            Calcium = 1;
            VitaminD = 6;
            VitaminB12 = 43;
            VitaminC = 0;
            Iron = 12;
            VitaminB6 = 10;
            Magnesium = 3;
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
