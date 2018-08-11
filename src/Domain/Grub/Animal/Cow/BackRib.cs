﻿using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Cow
{
    public class BackRib : Food
    {
        public BackRib()
        {
            //1 Rib
            //G
            Grams = 85;
            Fat = new Fat { Grams = 10, Polyunsaturated = 0, Saturated = 4, Monounaturated = 4 };
            Calories = 187;
            Carbohydrate = new Carbohydrate { Grams = 0, DietaryFiber = 0, Sugar = 0 };

            //Mg
            Cholesterol = 69;
            Sodium = 62;
            Potassium = 304;

            //Percent
            Protein = 23;
            VitaminA = 0;
            Calcium = 7;
            VitaminD = 0;
            VitaminB12 = 22;
            VitaminC = 0;
            Iron = 3;
            VitaminB6 = 0;
            Magnesium = 21;
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
