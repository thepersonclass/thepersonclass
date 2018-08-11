﻿using Domain.Grub.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Grub.Animal.Cow
{
    public class Brisket : Food
    {
        public Brisket()
        {
            //G
            Grams = 100;
            Fat = new Fat { Grams = 7, Polyunsaturated = 0, Saturated = 3, Monounaturated = 4 };
            Calories = 155;
            Protein = 21;

            //Mg
            Cholesterol = 62;
            Sodium = 79;
            Potassium = 330;
            Carbohydrate = new Carbohydrate { DietaryFiber = 0, Sugar = 0 };

            //Percent
            VitaminA = 0;
            Calcium = 0;
            VitaminD = 0;
            VitaminB12 = 40;
            VitaminC = 0;
            Iron = 10;
            VitaminB6 = 20;
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
