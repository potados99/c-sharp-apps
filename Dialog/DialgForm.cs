using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog
{
    public partial class DialgForm : Form
    {
        public DialgForm(string message)
        {
            InitializeComponent();
            MessageLabel.Text = message;
        }

        #region Button click listener

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
