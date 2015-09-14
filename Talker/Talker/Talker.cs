using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talker
{
    class Talker
    {
        public static int blaBlaBla(string thingToSay, int numberOfTimes)
        {
            string finalString = "";
            for(int i = 1; i <= numberOfTimes; i++)
            {
                finalString = finalString + thingToSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
