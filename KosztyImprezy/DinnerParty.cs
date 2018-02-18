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
        

        public int NumberOfPeople { get; set; }
        public decimal CostOfBeveragesPerPerson { get; set; }
        public decimal CostOfDecorations = 0;


        public void SetHealthyOption(bool healthyOption)
        {
            if(healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }
        public void CalculateCostOfDecoration(bool fancy)
        {
            if(fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool healthyOtion)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
            if(healthyOtion)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }

        }
    }
}