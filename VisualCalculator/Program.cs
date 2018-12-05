using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualCalculator
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var a = new Models.CalculatorModel();

            a.AddCalcObject(new Models.CalcObject(Models.CalcObject.Type.NUM, 2));
            a.AddCalcObject(new Models.CalcObject(Models.CalcObject.Type.OP_PLUS, 0));
            a.AddCalcObject(new Models.CalcObject(Models.CalcObject.Type.NUM, 3));
            a.AddCalcObject(new Models.CalcObject(Models.CalcObject.Type.OP_MULTIPLY, 0));
            a.AddCalcObject(new Models.CalcObject(Models.CalcObject.Type.NUM, 6));
            a.AddCalcObject(new Models.CalcObject(Models.CalcObject.Type.OP_MINUS, 6));
            a.AddCalcObject(new Models.CalcObject(Models.CalcObject.Type.NUM, 20));

            var b = a.Calculate();

            Console.WriteLine(b.ToString());

            Console.WriteLine("test done");

            // Application.Run(new Forms.CalcForm());
        }
    }
}
