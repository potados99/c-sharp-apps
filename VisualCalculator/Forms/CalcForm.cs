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

            VM.UserPressedThisNumber(2);
            VM.UserPressedThisNumber(3);
            VM.UserPressedThisNumber(10);
            VM.UserPressedThisNumber(4);
            Console.WriteLine(VM.GetDisplayString());
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

        }

        private void OperationButtonPressed(ViewModel.CalcFormViewModel.OperationButtons operation)
        {
            switch (operation)
            {
                case CalcFormViewModel.OperationButtons.Divide:
                    break;
                case CalcFormViewModel.OperationButtons.Minus:
                    break;
                case CalcFormViewModel.OperationButtons.Multiply:
                    break;
                case CalcFormViewModel.OperationButtons.Plus:
                    break;
                default:
                    break;
            }
        }

        private void ActionButtonPressed(ViewModel.CalcFormViewModel.ActionButtons action)
        {
            switch (action)
            {
                case CalcFormViewModel.ActionButtons.Remove:
                    MessageBox.Show("eee");
                    break;
                case CalcFormViewModel.ActionButtons.ClearError:
                    break;
                case CalcFormViewModel.ActionButtons.Clear:
                    break;
                case CalcFormViewModel.ActionButtons.Equel:
                    break;
                case CalcFormViewModel.ActionButtons.Root:
                    break;
                case CalcFormViewModel.ActionButtons.Percent:
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
