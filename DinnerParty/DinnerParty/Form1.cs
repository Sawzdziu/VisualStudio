using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty {
    public partial class Form1 : Form {

        DinnerParty dinnerParty;
        public Form1() {
            InitializeComponent();
            dinnerParty = new DinnerParty() { numberOfPeople = 5 };
            dinnerParty.setHealthyOption(false);
            dinnerParty.calculateCostOfDecorations(true);
            displayDinnerPartyCost();
        }

        private void displayDinnerPartyCost() {
            decimal cost = dinnerParty.calculateCost(healthyOptionCheckButton.Checked);
            costVisualLabel.Text = cost.ToString("c");
        }

        private void numberOfPeopleUpDown_ValueChanged(object sender, EventArgs e) {
            dinnerParty.numberOfPeople = (int)numberOfPeopleUpDown.Value;
            displayDinnerPartyCost();
        }

        private void decorationCheckButton_CheckedChanged(object sender, EventArgs e) {
            //CheckBox check = (CheckBox)sender;
            dinnerParty.calculateCostOfDecorations(((CheckBox)sender).Checked);
            displayDinnerPartyCost();
        }

        private void healthyOptionCheckButton_CheckedChanged(object sender, EventArgs e) {
            dinnerParty.setHealthyOption(((CheckBox)sender).Checked);
            displayDinnerPartyCost();
        }
    }
}
