using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hazard {
    class Bet {
        public int amount;
        public int dog;
        public Booker booker;
        public Label description;

        public void getDescription() {
            description.Text = booker.name + " postawił " + amount + " zł na psa numer " + dog;
        }

        public int payOut(int winner) {
            if (winner == dog) {
                description.Text = "Gratulujemy! Wygraj jeszcze raz!";
                return amount;
            }
            else {
                description.Text = "Postaw jeszcze raz! Odkuj się!";
                return -amount;
            }
        }
    }
}
