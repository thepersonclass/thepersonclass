using Domain.Grub.Base;
using System.Collections.Generic;

namespace Domain.Grub.Animal.Cow
{
    /// <summary>
    /// Korean style short ribs. Usually thinly cut across the rib bones 1/2 inch thick.
    /// </summary>
    public class FlankenStyleRibs : Food
    {
        public FlankenStyleRibs()
        {
            Grams = 112;
            Fat = new Fat { Grams = 19, Saturated = 9 };
            Calories = 250;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0 };
            Protein = 20;

            //Mg
            Cholesterol = 40;
            Sodium = 42;
            Potassium = 0;

            //Percent
            VitaminA = 3;
            Calcium = 0;
            VitaminD = 0;
            VitaminB12 = 129;
            VitaminC = 65;
            Iron = 30;
            VitaminB6 = 52;
            Magnesium = 15;
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
