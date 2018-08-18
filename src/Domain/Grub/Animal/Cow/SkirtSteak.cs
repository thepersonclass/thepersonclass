﻿using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Cow
{
    public class SkirtSteak : Food
    {
        public SkirtSteak()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 12, Polyunsaturated = 1, Saturated = 5, Monounaturated = 6 };
            Calories = 220;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0 };
            Protein = 26;

            //Mg
            Cholesterol = 60;
            Sodium = 75;
            Potassium = 289;

            //Percent
            VitaminA = 0;
            Calcium = 1;
            VitaminD = 0;
            VitaminB12 = 61;
            VitaminC = 0;
            Iron = 15;
            VitaminB6 = 15;
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
