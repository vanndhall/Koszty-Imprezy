using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KosztyImprezy
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        
        // własności
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        //Konsturktor aktualizujący własności^^
        public DinnerParty(int numberOfPeople, bool healthyOtion, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOtion;
        }

        // Metoda prywatna obliczająca koszt dekoracji
        decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if(FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
            return costOfDecorations;

        }
        //Metoda prywatna obliczająca koszt napoju za osobę
        decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if(HealthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
            }
            return costOfBeveragesPerPerson;
        }
        //własność/metoda publiczna obliczająca koszt imprezy.
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
                if(HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }

        }


    }
}