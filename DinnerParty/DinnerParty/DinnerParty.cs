using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty {
    class DinnerParty {
        const int costOfFoodPerPerson = 25;
        public int numberOfPeople;
        public decimal costOfBeveragesPerPerson;
        public decimal costOfDecorations;
        public bool healthyOption;

        public void setHealthyOption(bool healthyOption) {
            if (healthyOption) {
                costOfBeveragesPerPerson = 5.00M;
            }
            else {
                costOfBeveragesPerPerson = 20.0M;
            }
        }

        public void calculateCostOfDecorations(bool fancy) {
            if (fancy) {
                costOfDecorations = (numberOfPeople * 15.0M) + 50M;
            }
            else {
                costOfDecorations = (numberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal calculateCost(bool healthyOption) {
            decimal totalCost = costOfDecorations + ((costOfBeveragesPerPerson + costOfFoodPerPerson) * numberOfPeople);
            if (healthyOption) {
                return totalCost * .95M;
            }
            else {
                return totalCost;
            }
        }
    }
}
