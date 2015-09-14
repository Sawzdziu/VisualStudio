using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colours
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                for(int i = 0; i <= 254 && Visible == true; i++)
                {
                    this.BackColor = Color.FromArgb(i, 255 - i, i);
                    button1.BackColor = this.BackColor;
                    
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(1);
                }
                for (int i = 254; i >= 0 && Visible == true; i--)
                {
                    this.BackColor = Color.FromArgb(i, 255 - i, i);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
            }
        }
    }
}
