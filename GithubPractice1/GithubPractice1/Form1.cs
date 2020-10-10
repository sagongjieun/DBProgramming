using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GithubPractice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButtonOperator1.Text = "*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float oper1 = float.Parse(textBoxOperand1.Text);
            float oper2 = float.Parse(textBoxOperand2.Text);
            float result = 0;

            string oper = "";

            if(radioButtonPlus.Checked)
            {
                oper = "+";
                result = oper1 + oper2;
            } else if(radioButtonMinus.Checked)
            {
                oper = "-";
                result = oper1 - oper2;
            } else if(radioButtonOperator1.Checked)
            {
                oper = "*";
                result = oper1 * oper2;
            }

            textBoxResult.Text = oper1 + oper + oper2 + " = " + result;
            //최종 제출용 태그 추가
        }
    }
}
