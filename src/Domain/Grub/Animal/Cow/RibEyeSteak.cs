﻿using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Cow
{
    public class RibEyeSteak : Food
    {
        public RibEyeSteak()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 22, Polyunsaturated = 1, Saturated = 10, Monounaturated = 11 };
            Calories = 291;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0 };
            Protein = 24;

            //Mg
            Cholesterol = 80;
            Sodium = 54;
            Potassium = 260;

            //Percent
            VitaminA = 0;
            Calcium = 1;
            VitaminD = 1;
            VitaminB12 = 35;
            VitaminC = 0;
            Iron = 12;
            VitaminB6 = 25;
            Magnesium = 5;
        }

        public void Boil()
        {
            throw new System.NotImplementedException();
        }

        public void Broil()
        {
            Grams = 123;
        }

        public void DeepFry()
        {
            throw new System.NotImplementedException();
        }

        public void PanFry()
        {
            throw new System.NotImplementedException();
        }
    }
}
