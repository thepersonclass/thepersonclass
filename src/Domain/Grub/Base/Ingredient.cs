using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Base
{
    public abstract class Ingredient
    {
        public int Grams { get; protected set; }
        public Fat Fat { get; protected set; }
        public int Calories { get; protected set; }
        public int Cholesterol { get; protected set; }
        public int Sodium { get; protected set; }
        public int Potassium { get; protected set; }
        public Carbohydrate Carbohydrate { get; protected set; }
        public int Protein { get; protected set; }
        public int VitaminA { get; protected set; }
        public int Calcium { get; protected set; }
        public int VitaminD { get; protected set; }
        public int VitaminB12 { get; protected set; }
        public int VitaminC { get; protected set; }
        public int Iron { get; protected set; }
        public int VitaminB6 { get; protected set; }
        public int Magnesium { get; protected set; }
    }
}
