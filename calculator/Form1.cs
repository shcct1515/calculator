namespace calculator
{
    public partial class calculator : Form
    {
        string userinput;
        string[] op;
        double num1, num2;
        double equal = 0;
        double ans;

        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userinput = textBox1.Text;
            op = userinput.Split(' ');
            num1 = Convert.ToDouble(op[0]);
            num2 = Convert.ToDouble(op[2]);
            equal = dosomething();
            textBox1.Text = Convert.ToString(equal);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ans = equal;
            textBox1.Text = Convert.ToString(ans);
        }

        private double dosomething()
        {
            switch (op[1])
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("khong the chia cho 0");
                        return 0;
                    }
                    else
                    {
                        return Math.Round(num1 / num2, 3);
                    }
                default:
                    break;
            }
            return 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            int b = (int)a;
            string binary = Convert.ToString(b, 2);
            textBox1.Text = binary;
        }
    }
}
