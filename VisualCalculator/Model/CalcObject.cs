using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCalculator.Model
{
    public class CalcObject
    {
        public enum Type
        {
            NUM = 0x00,
            OP_PLUS = 0x01,
            OP_MINUS = 0x02,
            OP_MULTIPLY = 0x01 << 0x04 | 0x01,
            OP_DIVIDE = 0x01 << 0x04 | 0x02
        }

        public Type ObjectType;
        public Double Number;


        public CalcObject(Type type, double number)
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
