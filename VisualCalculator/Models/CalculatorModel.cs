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

        public Queue<CalcObject> ToPostFix()
        {
            Queue<CalcObject> PostFixQueue = new Queue<CalcObject>();
            Stack<CalcObject> OperatorStack = new Stack<CalcObject>();
 
            // iterate user input queue and iterate
            while (this.UserInputQueue.Count > 0)
            {
                CalcObject userCalcObject = this.UserInputQueue.Dequeue();

                if (userCalcObject.ObjectType == CalcObject.Type.NUM)
                {
                    // if the object is a number
                    PostFixQueue.Enqueue(userCalcObject);
                }
                else
                {
                    // if the object is an operator
                    int existingOperatorWeight = OperatorStack.Count != 0 ? (int)OperatorStack.Peek().ObjectType : 0;
                    if (existingOperatorWeight >= (int)userCalcObject.ObjectType)
                    {
                        // if bigger or same weighted operator is in operator stack, pop it and enqueue in PostFix
                        PostFixQueue.Enqueue(OperatorStack.Pop());
                    }

                    // add operator to operator stack
                    OperatorStack.Push(userCalcObject);
                }





            }

            // now move from operator stack to postfix queue
            int operatorStackCount = OperatorStack.Count; // temp
            for (int i = 0; i < operatorStackCount; i ++)
            {
                UserInputQueue.Enqueue(OperatorStack.Pop());
            }

            return PostFixQueue;

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
        public enum Type {
            NUM = 0x00,
            OP_PLUS = 0x01,
            OP_MINUS = 0x02,
            OP_MULTIPLY = 0x01 << 0x04 | 0x01,
            OP_DIVIDE = 0x01 << 0x04 | 0x01
        }

        public CalcObject (Type type, double number)
        {
            this.ObjectType = type;
            this.Number = number;
        }

        public Type ObjectType;
        public Double Number;
    }

}
