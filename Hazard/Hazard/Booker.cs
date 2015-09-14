using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hazard {
    class Booker {
        public String name;
        public Bet myBet;
        public int cash;
        public RadioButton myRadioButton;
        public Label myLabel;
        public Label description;

        public void updateLabels() {
            myLabel.Text = name + " ma " + cash.ToString() + " zł";
            if(cash <= 5) {
                description.Text = name + " nie ma już pieniędzy do obstawiania";
            }
        }

        public void noBetDescription() {
            description.Text = name + " nie postawił zakładu";
        }

        public void firstDescription() {
            description.Text = "Postaw coś";
        }


        public void clearBet() {
            myBet.amount = 0;
        }

        public bool placeBet(int amount, int Dog) {
            if (cash - amount > 0) {
                myBet = new Bet() { amount = amount, dog = Dog, booker = this, description = this.description };
                myBet.getDescription();
                return true;
            }
            else {
                return false;
            }
        }

        public void collect(int winner) {
            cash += myBet.payOut(winner);
        }

        public override string ToString() {
            return name + " kasa: " + cash;
        }
    }
}
