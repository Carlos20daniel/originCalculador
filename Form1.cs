
namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        double a, b, c;
        string d;
        public Form1()
        {
            InitializeComponent();
        }
        public void process(string s)
        {
            d = s;
            a = Convert.ToDouble(T.Text);
            T.clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            KeyEnter(0);
        }

        private static void KeyEnter(int i)
        {
            if (T.Text == "0")
                T.Text = i.ToString();
            else
                T.Text += i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button24_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(T.Text);
            switch (d)
            {
                case "/":
                    c = a / b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
            }
            T.Text = c.ToString();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            process("+");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            process("*");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            process("/");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            KeyEnter(8);

        }
        private void button14_Click(object sender, EventArgs e)
        {
            KeyEnter(5);

        }
        private void button15_Click(object sender, EventArgs e)
        {
            KeyEnter(6);

        }
        private void button22_Click(object sender, EventArgs e)
        {
            KeyEnter(0);
        }
        private void button23_Click(object sender, EventArgs e)
        {

        }
        private void button17_Click(object sender, EventArgs e)
        {
            KeyEnter(1);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            KeyEnter(2);
        }
        private void button19_Click(object sender, EventArgs e)
        {
            KeyEnter(3);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            KeyEnter(4);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            KeyEnter(7);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            KeyEnter(9);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            T.Clear();
            T.Text = "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            process("-");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}