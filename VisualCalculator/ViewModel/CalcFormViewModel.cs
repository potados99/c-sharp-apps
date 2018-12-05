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
            if (HandlingOperator)
            {
                // right after the operator
                ClearCurrent();

                HandlingOperator = false;
            }

            UpdateCurrentNumber(num);
        }

        public void UserPressedThisOperation(OperationButtons operation)
        {
            if (HandlingOperator)
            {
                if (M.PopCalcObject().ObjectType == Model.CalcObject.Type.NUM)
                {
                    throw new Exception("Expecting operator.");
                }
            }

            ClearInputNumberData(); // decimal digit info
            RefreshSavedOperator(operation); // last operator and current operator

            M.AddCalcObject(new Model.CalcObject(Model.CalcObject.Type.NUM, this.CurrentNumber));

            if ((int)CurrentOperator >> 4 > (int)LastOperator >> 4)
            {
                // operator weight increased
                // do nothing.
            }
            else
            {
                if (M.Nums == 1)
                {
                    // do nothing
                }
                else
                {
                    this.CurrentNumber = M.Calculate();
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
                    break;

                case CalcFormViewModel.ActionButtons.ClearError:
                    break;

                case CalcFormViewModel.ActionButtons.Clear:
                    break;

                case CalcFormViewModel.ActionButtons.Equel:
                    M.AddCalcObject(new Model.CalcObject(Model.CalcObject.Type.NUM, this.CurrentNumber));
                    this.CurrentNumber = M.Calculate();
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
