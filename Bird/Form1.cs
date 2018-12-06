using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird
{
    public partial class Form1 : Form
    {
        private int index { get; set; }

        public Form1()
        {
            InitializeComponent();

            MyNumericUpDown.Minimum = 1;

            MyTimer.Tick += (s, e) =>
            {
                MainLabel.Image = MyImageList.Images[index];
                index = (index + 1) % MyImageList.Images.Count;
            };

            MyTimer.Start();
        }

        private void MyNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MyTimer.Stop();
            MyTimer.Interval = 100 / (int)(sender as NumericUpDown).Value;
            MyTimer.Start();
        }
    }
}
