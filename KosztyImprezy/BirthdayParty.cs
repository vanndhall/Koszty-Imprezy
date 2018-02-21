﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosztyImprezy
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;


        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public string CakeWriting { get; set; }

        public BirthdayParty(int numberOfPeople,bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWrithingLength())
                    return MaxWrithingLength();
                else
                    return CakeWriting.Length;
            }
        }

        int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 20;
            else
                return 40;
        }

        int MaxWrithingLength()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWrithingLength())
                    return true;
                else
                    return false;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            return costOfDecorations;
        }


    }
}