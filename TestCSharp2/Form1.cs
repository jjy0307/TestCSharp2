using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            textBox2.Text += $"{numA2_1}에 {numA2_2}을 더하면 {numA2_1 + numA2_2}입니다. \r\n";

            textBox3.Text = "A3. \r\n";

            string productName = "노트북";
            int priceA3 = 1200000;
            float discount = 0.15f;
            byte stock = 8;
            //bool isAvailable = stock >= 1;
            bool isAvailable = (stock >= 1) ? true : false;

            double discounted = Math.Round(priceA3 * (1 - discount), 0);

            //if (isAvailable)
            //{
            //    textBox1.Text += $"구매 가능: 할인 가격은 {discounted}원 입니다.";
            //}
            //else
            //{
            //    textBox1.Text += "품절되었습니다.";
            //}
            string resultMessage = (stock > 0) ? $"구매 가능: 할인 가격은 {discounted}원 입니다." : "품절되었습니다.";
            textBox1.Text += resultMessage;
            //if (stock >= 5)
            //{
            //    textBox2.Text += "여유 있음";
            //}
            //else
            //{
            //    textBox2.Text += "소량 남음";
            //}
            textBox2.Text += (stock >= 5) ? "여유 있음" : "소량 남음";
            textBox3.Text += $"상품명: {productName}, 할인된 가격: {discounted}원, 재고: {stock}개";
        }
    }
}
