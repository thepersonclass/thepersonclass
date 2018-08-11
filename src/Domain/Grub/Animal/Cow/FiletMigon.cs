﻿using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Cow
{
    public class FiletMigon : Food
    {
        public FiletMigon()
        {
            //1 Steak
            Grams = 100;
            Fat = new Fat { Grams = 18, Polyunsaturated = 1, Saturated = 7, Monounaturated = 7 };
            Calories = 278;
            Cholesterol = 101;
            Protein = 28;

            //Mg
            Sodium = 56;
            Potassium = 342;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0 };

            //Percent
            VitaminA = 0;
            Calcium = 2;
            VitaminD = 2;
            VitaminB12 = 26;
            VitaminC = 0;
            Iron = 9;
            VitaminB6 = 30;
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
