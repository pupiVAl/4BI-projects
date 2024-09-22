namespace calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int n1;
        int n2;
        string operation;
        int result;

        private void calculatorDisplay_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = "+";
            n1 = int.Parse(calculatorDisplay.Text);
            calculatorDisplay.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = "-";
            n1 = int.Parse(calculatorDisplay.Text);
            calculatorDisplay.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation = "*";
            n1 = int.Parse(calculatorDisplay.Text);
            calculatorDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            n1 = int.Parse(calculatorDisplay.Text);
            calculatorDisplay.Clear();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            n1 = (0);
            n2 = (0);
            result = (0);
            calculatorDisplay.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            n2 = int.Parse(calculatorDisplay.Text);

            if (operation.Equals("+"))
                result = n1 + n2;   
            if (operation.Equals("-"))
                result = n1 - n2;
            if (operation.Equals("*"))
                result = n1 * n2;
            if (operation.Equals("/"))
                result = n1 / n2;

            calculatorDisplay.Text = result.ToString();
        }
    }
}
