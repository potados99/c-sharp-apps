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

        public string GetCalcObjects()
        {
            string outStr = "";
            foreach (var item in UserInputQueue)
            {
                outStr += item.ToString();
            }
            return outStr;
        }

        public double Calculate()
        {
            Queue<CalcObject> postFixQueue = ToPostFix(this.UserInputQueue);
            return CalculatePostfixQueue(postFixQueue);
        }

        private Queue<CalcObject> ToPostFix(Queue<CalcObject> userInputQueue)
        {
            Queue<CalcObject> postFixQueue = new Queue<CalcObject>();
            Stack<CalcObject> operatorStack = new Stack<CalcObject>();
 
            // iterate user input queue and iterate
            while (userInputQueue.Count > 0)
            {
                CalcObject userCalcObject = this.UserInputQueue.Dequeue();

                if (userCalcObject.ObjectType == CalcObject.Type.NUM)
                {
                    // if the object is a number
                    postFixQueue.Enqueue(userCalcObject);
                }
                else
                {
                    if (postFixQueue.Count == 0)
                    {
                        throw new Exception("Converting Infix Queue to Postfix Queue: Encountered operator before first number.");
                    }

                    // if the object is an operator
                    int existingOperatorWeight = operatorStack.Count != 0 ? (int)operatorStack.Peek().ObjectType : 0;
                    if (existingOperatorWeight >= (int)userCalcObject.ObjectType)
                    {
                        // if bigger or same weighted operator is in operator stack, pop it and enqueue in PostFix
                        postFixQueue.Enqueue(operatorStack.Pop());
                    }

                    // add operator to operator stack
                    operatorStack.Push(userCalcObject);
                }





            }

            // now move from operator stack to postfix queue
            int operatorStackCount = operatorStack.Count; // temp
            for (int i = 0; i < operatorStackCount; i ++)
            {
                postFixQueue.Enqueue(operatorStack.Pop());
            }

            return postFixQueue;
        }

        private double CalculatePostfixQueue(Queue<CalcObject> postfixQueue)
        {
            Stack<double> resultStack = new Stack<double>();

            int queueCount = postfixQueue.Count;
            for (int i = 0; i < queueCount; ++ i)
            {
                CalcObject currentObject = postfixQueue.Dequeue();
                
                if (currentObject.ObjectType == CalcObject.Type.NUM)
                {
                    resultStack.Push(currentObject.Number);
                }
                else
                {
                    // encountered an operator.
                    if (resultStack.Count < 2)
                    {
                        throw new Exception("Calculating Postfix Queue: Encountered operator before two numbers.");
                    }

                    double right = resultStack.Pop();
                    double left = resultStack.Pop();

                    double result;

                    switch (currentObject.ObjectType)
                    {
                        case CalcObject.Type.OP_PLUS:
                            result = left + right;
                            break;
                        case CalcObject.Type.OP_MINUS:
                            result = left - right;
                            break;
                        case CalcObject.Type.OP_MULTIPLY:
                            result = left * right;
                            break;
                        case CalcObject.Type.OP_DIVIDE:
                            result = left / right;
                            break;
                        default:
                            throw new Exception("Calculating Postfix Queue: There must be an operator.");
                    }

                    resultStack.Push(result);
                }
            }

            if (resultStack.Count != 1)
            {
                throw new Exception("Calculating Postfix Queue: Expected next operator.");
            }

            return resultStack.Pop();
        }


    }

    public class CalcObject
    {
        public enum Type {
            NUM = 0x00,
            OP_PLUS = 0x01,
            OP_MINUS = 0x02,
            OP_MULTIPLY = 0x01 << 0x04 | 0x01,
            OP_DIVIDE = 0x01 << 0x04 | 0x02
        }

        public Type ObjectType;
        public Double Number;

        public CalcObject (Type type, double number)
        {
            this.ObjectType = type;
            this.Number = number;
        }

        public override string ToString()
        {
            string returnStr = "";

            switch (ObjectType)
            {
                case Type.NUM:
                    returnStr = Number.ToString();
                    break;
                case Type.OP_PLUS:
                    returnStr = "+";
                    break;
                case Type.OP_MINUS:
                    returnStr = "-";
                    break;
                case Type.OP_MULTIPLY:
                    returnStr = "*";
                    break;
                case Type.OP_DIVIDE:
                    returnStr = "/";
                    break;
            }

            return returnStr;
        }

    }

}
