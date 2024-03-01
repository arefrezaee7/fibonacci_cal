namespace fibonacci_cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private int Fibonacci(int number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(number - 1) + Fibonacci(number - 2);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int ans = int.Parse(textBox1.Text);
            if (ans > 30)
            {
                MessageBox.Show("the given value is too big to calculate");
            }
            else
            {
                MessageBox.Show("the fibunacci sequence is  " + Fibonacci(ans));
            }
        }
    }
}
