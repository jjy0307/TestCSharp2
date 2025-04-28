using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCSharp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "A1. \r\n";

            string apple = "사과";
            int priceA1 = 1200;
            int numA1 = 5;

            textBox1.Text += $"{apple} {numA1.ToString()}개의 총 가격은 {priceA1 * numA1}원 입니다. \r\n";

            textBox2.Text = "A2. \r\n";

            string strNum = "15";
            int numA2_1 = int.Parse(strNum);
            int numA2_2 = 10;

            textBox2.Text += $"{numA2_1 + "에 " + numA2_2 + "을 더하면 " + (numA2_1 + numA2_2) + "입니다."} \r\n";

        }
    }
}
