using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCalculator.Models
{
    class CalculatorModel
    {
        public Queue<CalcObject> UserInputQueue { get; private set;}

 
        public CalculatorModel()
        {
            this.UserInputQueue = new Queue<CalcObject>();
         }

        public void AddCalcObject(CalcObject ob)
        {
            this.UserInputQueue.Enqueue(ob);
        }

        public void ClearCalcObejcts()
        {
            this.UserInputQueue.Clear();
         }

        private Queue<CalcObject> ToPostFix()
        {
            Queue<CalcObject> PostFix = new Queue<CalcObject>();
            Stack<CalcObject> OperatorStack = new Stack<CalcObject>();
 
            while (this.UserInputQueue.Count > 0)
            {
                CalcObject ob = this.UserInputQueue.Dequeue();

                if (ob.Obje)




            }

            return PostFix;

            /*
             * 1 + 2 * 3
             * 
             * postfix stack: 1 2 3 + *         
             * operator stack: + *
             * 
             * then: 
             * 
             * num stack: 
             * 
             * 
             * 
             * 
             */
        }

        private double CalculatePostfixStack()
        {
            CalcObject a;
            return 0F;
        }





    }

    public class CalcObject
    {
        public enum Kind {
            NUM = 0,
            OPERATION = 1
        }

        public enum Operator
        {
            PLUS = 1,
            MINUS = 2,
            MULTIPLY = 1 << 4 | 1,
            DIVIDE = 1 << 4 | 2
        }

        public CalcObject (Kind kind, double content)
        {
            this.ObjectKind = kind;
            this.Number = content;
        }

        public Kind ObjectKind;
        public Double Number;
    }

}
