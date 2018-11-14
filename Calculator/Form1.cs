using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    enum OPERATIONS
    {
        PLUS = 1,
        MINUS = 2,
        MULTIPLY = 3,
        DIVIDE = 4
    }


    public partial class Form1 : Form
    {
        private OPERATIONS Operation { get; set; }

        public Form1()
        {
            InitializeComponent();

            var source = new List<ComboboxMember>
            {
                new ComboboxMember() { DisplayMember = "Addition", ItemNumber = 1 },
                new ComboboxMember() { DisplayMember = "Subtraction", ItemNumber = 2 },
                new ComboboxMember() { DisplayMember = "Multiplification", ItemNumber = 3 },
                new ComboboxMember() { DisplayMember = "Division", ItemNumber = 4 }
            };

            OpComboBox.DataSource = source;
            OpComboBox.DisplayMember = "DisplayMember";
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            var left = LeftBox.Text;
            var right = RightBox.Text;

            bool lsuc = Double.TryParse(left, out double leftNum);
            bool rsuc = Double.TryParse(right, out double rightNum);

            if (!lsuc)
            {
                MessageBox.Show("좌변에 숫자를 쓰세욧!!");
            }
            if (!rsuc)
            {
                MessageBox.Show("우변에 숫자를 쓰세욧!!");
            }

            if (!(lsuc && rsuc)) return;

            if (rightNum == 0 && Operation == OPERATIONS.DIVIDE)
            {
                MessageBox.Show("0으로 나누지 마세욧!!");
                return;
            }

            double result;
            switch (Operation)
            {
                case OPERATIONS.PLUS:
                    result = leftNum + rightNum;
                    break;
                case OPERATIONS.MINUS:
                    result = leftNum - rightNum;
                    break;
                case OPERATIONS.MULTIPLY:
                    result = leftNum * rightNum;
                    break;
                case OPERATIONS.DIVIDE:
                    result = leftNum / rightNum;
                    break;
                default:
                    throw new Exception("이게 뜨면 안되는데...?");
            }

            ResultTextBox.Text = result.ToString(format:"N2");
        }

        private void OpComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operation = (OPERATIONS)(OpComboBox.SelectedItem as ComboboxMember).ItemNumber;
        }
    }
}
