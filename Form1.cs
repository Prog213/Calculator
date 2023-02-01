
namespace Calculator
{
    public partial class Form1 : Form
    {
        public bool flag;
        public string toDo, rem, number;
        public double result, lastnumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double number1, result;
            number1 = Convert.ToDouble(textBox1.Text);
            result = -number1;
            textBox1.Text = Convert.ToString(result);
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                textBox1.Text = null;
            }
            Button b = (Button)sender;


            if (textBox1.Text.Length <= 22)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = b.Text;
                }
                else
                {
                    textBox1.Text += b.Text;
                }
                lastnumber = Convert.ToDouble(textBox1.Text);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            toDo = b.Text;
            rem = toDo;
            number = textBox1.Text;
            flag = true;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            double number1, number2;
            number1 = Convert.ToDouble(number);
            number2 = Convert.ToDouble(textBox1.Text);
            switch (toDo)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                case "%":
                    result = number1 * number2 / 100;
                    break;
                case "=":
                    switch (rem)
                    {
                        case "+":
                            result += lastnumber;
                            break;
                        case "-":
                            result -= lastnumber;
                            break;
                        case "*":
                            result *= lastnumber;
                            break;
                        case "/":
                            result /= lastnumber;
                            break;
                    }
                    break;
            }
            toDo = "=";
            flag = true;
            textBox1.Text = Convert.ToString(result);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double number1, result;
            number1 = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(number1);
            textBox1.Text = Convert.ToString(result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double number1, result;
            number1 = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(number1, 2);
            textBox1.Text = Convert.ToString(result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double number1, result;
            number1 = Convert.ToDouble(textBox1.Text);
            result = 1 / number1;
            textBox1.Text = Convert.ToString(result);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
                textBox1.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
            }
            else if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

        }
    }
}