using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualCalculator.Forms
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Name);
        }

        /// <summary>
        /// /, *, -, +
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Name);
        }

        /// <summary>
        /// rm, ce, c, =, root, percent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Name);
        }
    }
}
