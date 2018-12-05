using System;
using System.Collections.Generic;
using System.Linq;

namespace VisualCalculator.Model
{
    class CalculatorModel
    {
        public Queue<CalcObject> UserInputQueue { get; private set; }

        public int Nums
        {
            get
            {
                var q = from ob in UserInputQueue where ob.ObjectType == CalcObject.Type.NUM select ob;
                return q.Count();
            }
        }
        public int Ops
        {
            get
            {
                var q = from ob in UserInputQueue where ob.ObjectType != CalcObject.Type.NUM select ob;
                return q.Count();
            }
        }
        public CalculatorModel()
        {
            this.UserInputQueue = new Queue<CalcObject>();
        }

        public void AddCalcObject(CalcObject ob)
        {
            this.UserInputQueue.Enqueue(ob);
        }

        public CalcObject PopCalcObject()
        {
            int count = this.UserInputQueue.Count;

            var backupQueue = new Queue<CalcObject>(this.UserInputQueue);
            this.UserInputQueue.Clear();

            for (int i = 0; i < count - 1; ++ i)
            {
                UserInputQueue.Enqueue(backupQueue.Dequeue());
            }

            return backupQueue.Dequeue();
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
            // determined by this.UserInputQueue.

            Queue<CalcObject> postFixQueue = ToPostFix(this.UserInputQueue);
            double result = CalculatePostfixQueue(postFixQueue);

            if (this.UserInputQueue.Count != 0)
            {
                throw new Exception("Calculating: Calculating is done but UserInputQueue is not empty");
            }

            return result;
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
                    if (existingOperatorWeight > 0 && (existingOperatorWeight >> 4) >= ((int)userCalcObject.ObjectType >> 4))
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
            for (int i = 0; i < operatorStackCount; i++)
            {
                postFixQueue.Enqueue(operatorStack.Pop());
            }

            return postFixQueue;
        }

        private double CalculatePostfixQueue(Queue<CalcObject> postfixQueue)
        {
            Stack<double> resultStack = new Stack<double>();

            int queueCount = postfixQueue.Count;
            for (int i = 0; i < queueCount; ++i)
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

}
