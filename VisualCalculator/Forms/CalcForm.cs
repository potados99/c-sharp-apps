using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualCalculator.ViewModel;

namespace VisualCalculator.Forms
{
    public partial class CalcForm : Form
    {
        #region Variables

        private CalcFormViewModel VM { get; set; }

        #endregion

        public CalcForm()
        {
            InitializeComponent();

            VM = new CalcFormViewModel();
        }


        #region Button Click Listeners

        /// <summary>
        /// 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumButton_Click(object sender, EventArgs e)
        {
            NumberButtonPressed(Convert.ToInt32((sender as Button).Tag));
        }

        /// <summary>
        /// /, *, -, +
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpButton_Click(object sender, EventArgs e)
        {
            OperationButtonPressed((ViewModel.CalcFormViewModel.OperationButtons)Convert.ToInt32((sender as Button).Tag));
        }

        /// <summary>
        /// rm, ce, c, =, root, percent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcButton_Click(object sender, EventArgs e)
        {
            ActionButtonPressed((ViewModel.CalcFormViewModel.ActionButtons)Convert.ToInt32((sender as Button).Tag));
        }

        #endregion

        #region Private

        private void NumberButtonPressed(int number)
        {
            VM.UserPressedThisNumber(number);
            Refresh();
        }

        private void OperationButtonPressed(ViewModel.CalcFormViewModel.OperationButtons operation)
        {
            VM.UserPressedThisOperation(operation);
            Refresh();
        }

        private void ActionButtonPressed(ViewModel.CalcFormViewModel.ActionButtons action)
        {
            VM.UserPressedThisAction(action);
            Refresh();
        }


        private void Refresh()
        {
            this.ResultTextBox.Text = VM.GetDisplayString();
        }

        #endregion
    }
}
