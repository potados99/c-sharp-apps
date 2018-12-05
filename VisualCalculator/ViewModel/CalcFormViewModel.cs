using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCalculator.ViewModel
{
    class CalcFormViewModel
    {
        public enum OperationButtons
        {
            Plus = Model.CalcObject.Type.OP_PLUS,
            Minus = Model.CalcObject.Type.OP_MINUS,
            Multiply = Model.CalcObject.Type.OP_MULTIPLY,
            Divide = Model.CalcObject.Type.OP_DIVIDE
        }

        public enum ActionButtons
        {
            Remove = 1,
            ClearError = 2,
            Clear = 3,
            Equel = 4,
            Root = 5,
            Percent = 6
        }

        private Model.CalculatorModel M { get; set; }

        private bool HandlingOperator = false;
        private bool CalculationDone = false;

        private OperationButtons CurrentOperator;
        private OperationButtons LastOperator;

        private double CurrentNumber = 0.0;
        private bool CurrentNumberHasDot = false;
        private int CurrentDecimalPlaces = 0;

        public CalcFormViewModel()
        {
            this.M = new Model.CalculatorModel();
        }

        public void UserPressedThisNumber(int num)
        {
            if (HandlingOperator || CalculationDone)
            {
                // right after the operator
                ClearCurrent();

                HandlingOperator = false;
            }

            CalculationDone = false;

            UpdateCurrentNumber(num);
        }

        public void UserPressedThisOperation(OperationButtons operation)
        {
            if (HandlingOperator)
            {
                CurrentOperator = operation;

                if (M.PopCalcObject().ObjectType == Model.CalcObject.Type.NUM)
                {
                    throw new Exception("Expecting operator.");
                }
            }
            else
            {
                ClearInputNumberData(); // decimal digit info
                RefreshSavedOperator(operation); // last operator and current operator

                M.AddCalcObject(new Model.CalcObject(Model.CalcObject.Type.NUM, this.CurrentNumber));

            }

            if ((int)CurrentOperator >> 4 > (int)LastOperator >> 4)
            {
                // operator weight increased
                // do nothing.
                this.CurrentNumber = M.LastNumber;
            }
            else
            {
                if (M.Nums == 1)
                {
                    // do nothing
                }
                else
                {
                    this.CurrentNumber = M.PreviewCalculate();
                }
            }

            M.AddCalcObject(new Model.CalcObject((Model.CalcObject.Type)operation, 0));

            HandlingOperator = true;
        }

        public void UserPressedThisAction(ActionButtons action)
        {
            switch (action)
            {
                case CalcFormViewModel.ActionButtons.Remove:
                    if (!CalculationDone)
                    {
                        UpdateCurrentNumber(-1);
                    }
                    break;

                case CalcFormViewModel.ActionButtons.ClearError:
                    ClearCurrent();
                    break;

                case CalcFormViewModel.ActionButtons.Clear:
                    ClearAll();
                    break;

                case CalcFormViewModel.ActionButtons.Equel:
                    M.AddCalcObject(new Model.CalcObject(Model.CalcObject.Type.NUM, this.CurrentNumber));
                    this.CurrentNumber = M.Calculate();
                    CalculationDone = true;
                    break;

                case CalcFormViewModel.ActionButtons.Root:
                    break;

                case CalcFormViewModel.ActionButtons.Percent:
                    break;

                default:
                    break;
            }
        }

        public string GetDisplayString()
        {
            string outStr = CurrentNumber.ToString();

            // placeholder zeros
            if (! HandlingOperator && CurrentNumberHasDot)
            {
                if (Math.Abs(CurrentNumber - Math.Floor(CurrentNumber)) > 0)
                {
                    //  valid decimal numbers
                }
                else
                {
                    // just zeros
                    outStr += ".";
                    for (int i = 0; i < CurrentDecimalPlaces; ++i)
                    {
                        outStr += "0";
                    }
                }
            }

            return outStr;
        }

        #region Private

        private void UpdateCurrentNumber(int num)
        {
            if (num == 10)
            {
                // if it is dot
                CurrentNumberHasDot = true;
            }
            else if (num == -1) {
                // number
                if (CurrentNumberHasDot)
                {
                    if(this.CurrentDecimalPlaces > 0)
                    {
                        double intPart = Math.Floor(this.CurrentNumber);
                        double decimalPart = this.CurrentNumber - intPart;

                        double lastDigit = (this.CurrentNumber * Math.Pow(10, this.CurrentDecimalPlaces)) % 10;
                        this.CurrentNumber -= lastDigit / Math.Pow(10, this.CurrentDecimalPlaces--);
                    }
                    else
                    {
                        CurrentNumberHasDot = false;
                    }
                }
                else
                {
                    CurrentNumber = Math.Floor(CurrentNumber / 10);
                }
                /*
                 * 24.96 (2 digits)
                 * num * Pow(10, decpls) = 2496
                 * 2496 % 10 = 6
                 * 6 / pow(10, decpls) = 0.06
                 * 24
                 * 
                 * 0.96
                 * 
                 * 9
                 * 
                 * 
                 * 
                 */
            }
            else
            {
                // number
                if (CurrentNumberHasDot)
                {
                    CurrentNumber += (double)num / (double)Math.Pow(10, ++CurrentDecimalPlaces);
                }
                else
                {
                    CurrentNumber = CurrentNumber * 10 + num;
                }
            }
        }


        private void ClearAll()
        {
            ClearCurrent();
            LastOperator = 0;

            M.ClearCalcObejcts();
        }

        private void ClearError()
        {
            ClearCurrent();
        }

        private void ClearCurrent()
        {
            HandlingOperator = false;
            CurrentOperator = 0;

            CurrentNumber = 0.0;
            CurrentNumberHasDot = false;
            CurrentDecimalPlaces = 0;
        }

        private void ClearInputNumberData()
        {
            this.CurrentNumberHasDot = false;
            this.CurrentDecimalPlaces = 0;
        }

        private void RefreshSavedOperator(OperationButtons operation)
        {
            LastOperator = CurrentOperator;
            CurrentOperator = operation;
        }

        #endregion
    }
}
