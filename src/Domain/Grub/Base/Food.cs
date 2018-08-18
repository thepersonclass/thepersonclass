using System.Collections.Generic;

namespace Domain.Grub.Base
{
    public abstract class Food
    {
        public double Grams { get; protected set; }
        public Fat Fat { get; protected set; }
        public double Calories { get; protected set; }
        public double Cholesterol { get; protected set; }
        public double Sodium { get; protected set; }
        public double Potassium { get; protected set; }
        public Carbohydrate Carbohydrate { get; protected set; }
        public double Protein { get; protected set; }
        public double VitaminA { get; protected set; }
        public double Calcium { get; protected set; }
        public double VitaminD { get; protected set; }
        public double VitaminB12 { get; protected set; }
        public double VitaminC { get; protected set; }
        public double Iron { get; protected set; }
        public double VitaminB6 { get; protected set; }
        public double Magnesium { get; protected set; }

        public virtual void Boil(IEnumerable<Ingredient> ingredients)
        {
            //Boiling meat reduces its size by 8.4%

            Grams = Grams - (Grams * 8.4 / 100);
            Calories = Calories - (Calories * 8.4 / 100);

            if (Fat != null)
            {
                Fat.Grams = Fat.Grams - (Fat.Grams * 8.4 / 100);
                Fat.TransFat = Fat.TransFat - (Fat.TransFat * 8.4 / 100);
                Fat.Monounaturated = Fat.Monounaturated - (Fat.Monounaturated * 8.4 / 100);
                Fat.Polyunsaturated = Fat.Polyunsaturated - (Fat.Polyunsaturated * 8.4 / 100);
                Fat.Saturated = Fat.Saturated - (Fat.Saturated * 8.4 / 100);
            }

            Cholesterol = Cholesterol - (Cholesterol * 8.4 / 100);
            Sodium = Sodium - (Sodium * 8.4 / 100);
            Potassium = Potassium - (Potassium * 8.4 / 100);

            VitaminA = VitaminA - (VitaminA * 8.4 / 100);
            Calcium = Calcium - (Calcium * 8.4 / 100);
            VitaminD = VitaminD - (VitaminD * 8.4 / 100);
            VitaminB12 = VitaminB12 - (VitaminB12 * 8.4 / 100);
            VitaminC = VitaminC - (VitaminC * 8.4 / 100);
            Iron = Iron - (Iron * 8.4 / 100);
            VitaminB6 = VitaminB6 - (VitaminB6 * 8.4 / 100);

            AddIngredients(ingredients);
        }

        public virtual void Broil(IEnumerable<Ingredient> ingredients)
        {
            //TODO: Will need to add logic for char and cancer. Will also
            //need logic to account for marinade to prevent cancer.

            AddIngredients(ingredients);
        }

        public virtual void PanFry(IEnumerable<Ingredient> ingredients)
        {

            AddIngredients(ingredients);
        }

        public virtual void DeepFry(IEnumerable<Ingredient> ingredients)
        {
            AddIngredients(ingredients);
        }

        private void AddIngredients(IEnumerable<Ingredient> ingredients)
        {
            foreach (var ingredient in ingredients)
            {
                //G
                Grams += ingredient.Grams;
                Calories += ingredient.Calories;
                Protein += ingredient.Protein;

                if (Fat != null && ingredient.Fat != null)
                {
                    Fat.Grams += ingredient.Fat.Grams;
                    Fat.TransFat += ingredient.Fat.TransFat;
                    Fat.Monounaturated += ingredient.Fat.Monounaturated;
                    Fat.Polyunsaturated += ingredient.Fat.Polyunsaturated;
                    Fat.Saturated += ingredient.Fat.Saturated;
                }

                //Mg
                Cholesterol += ingredient.Cholesterol;
                Sodium += ingredient.Sodium;
                Potassium += ingredient.Potassium;

                //Percent
                VitaminA += ingredient.VitaminA;
                Calcium += ingredient.Calcium;
                VitaminD += ingredient.VitaminD;
                VitaminB12 += ingredient.VitaminB12;
                VitaminC += ingredient.VitaminC;
                Iron += ingredient.Iron;
                VitaminB6 += ingredient.VitaminB6;
            }
        }
    }
}