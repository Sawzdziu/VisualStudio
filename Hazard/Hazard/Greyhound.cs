using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hazard {
    class Greyhound {
        public int startingPosition = 96;
        public int raceTrackLength;
        public PictureBox pictureBox = null;
        public int location = 0;
        public Random random = new Random();

        public bool run() {
            int forward = random.Next(10);
            Point point = pictureBox.Location;
            point.X += forward;
            pictureBox.Location = new Point(pictureBox.Location.X + forward, pictureBox.Location.Y);
            location += forward;
            if (location >= raceTrackLength) {
                return true;
            }
            else {
                return false;
            }
        }

        public void takeStartingPoint() {
            pictureBox.Location = new Point(startingPosition, pictureBox.Location.Y);
            location = 0;
        }


    }
}
