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
    }
}
