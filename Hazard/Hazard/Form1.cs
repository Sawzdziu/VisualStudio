using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Hazard {
    public partial class Form1 : Form {
        List<Greyhound> greyhoundArray;
        List<Booker> bookersArray;

        Greyhound jackson;
        Greyhound hagan;
        Greyhound harry;
        Greyhound fender;


        Booker janek;
        Booker ignacy;
        Booker piotrek;


        public Form1() {

            InitializeComponent();
            int raceTrack = background.Size.Width;
            Console.WriteLine(raceTrack.ToString());

            greyhoundArray = new List<Greyhound>();

            greyhoundArray.Add(jackson = new Greyhound() { pictureBox = jacksonDog, raceTrackLength = raceTrack });
            greyhoundArray.Add(hagan = new Greyhound() { pictureBox = haganDog, raceTrackLength = raceTrack });
            greyhoundArray.Add(harry = new Greyhound() { pictureBox = harryDog, raceTrackLength = raceTrack });
            greyhoundArray.Add(fender = new Greyhound() { pictureBox = fenderDog, raceTrackLength = raceTrack });

            bookersArray = new List<Booker>();
            bookersArray.Add(janek = new Booker() { name = "Janek", cash = 100, myLabel = janekLabel, myRadioButton = janekButton, description = janekDescription });
            bookersArray.Add(ignacy = new Booker() { name = "Ignacy", cash = 210, myLabel = ignacyLabel, myRadioButton = ignacyButton, description = ignacyDescription });
            bookersArray.Add(piotrek = new Booker() { name = "Piotrek", cash = 143, myLabel = piotrekLabel, myRadioButton = piotrekButton, description = piotrekDescription });

            //wyświetlenie incjalnych labelek :)
            foreach (Booker guy in bookersArray) {
                guy.updateLabels();
                guy.firstDescription();
            }


        }

        private void janekButton_CheckedChanged(object sender, EventArgs e) {
            activeBooker.Text = janek.name;

        }


        private void ignacyButton_CheckedChanged(object sender, EventArgs e) {
            activeBooker.Text = ignacy.name;
        }

        private void piotrekButton_CheckedChanged(object sender, EventArgs e) {
            activeBooker.Text = piotrek.name;
        }

        private void betButton_Click(object sender, EventArgs e) {
            int indexOfBooker = 0;

                switch (activeBooker.Text) {
                case "Janek":
                    indexOfBooker = 0;
                    break;
                case "Ignacy":
                    indexOfBooker = 1;
                    break;
                case "Piotrek":
                    indexOfBooker = 2;
                    break;
            }

            Booker help = bookersArray[indexOfBooker];
            help.placeBet((int)betAmount.Value, (int)dogNumber.Value);
            help.updateLabels();
        }

        private void startButton_Click(object sender, EventArgs e) {
            bool winner = true;
            int numberOfWinningDog = 0;
            foreach(Booker booker in bookersArray) {
                if(booker.myBet == null) {
                    booker.noBetDescription();
                }
            }

            while (winner) {
                foreach (Greyhound dog in greyhoundArray) {
                    System.Threading.Thread.Sleep(2);
                    if (dog.run()) {
                        numberOfWinningDog = greyhoundArray.IndexOf(dog) + 1;
                        winner = false;
                        MessageBox.Show("And the winner is dog number: " + numberOfWinningDog + "!!!");
                        foreach (Booker booker in bookersArray) {
                            if (booker.myBet != null) {
                                booker.collect(numberOfWinningDog);
                                booker.myBet = null;
                                booker.updateLabels();
                            }
                        }
                        foreach (Greyhound d in greyhoundArray) {
                            d.takeStartingPoint();
                        }
                        break;
                    }
                }
            }
        }
    }
}

