namespace lab01
{
    public partial class Form1 : Form
    {
        // class variable
        double input1 = 0;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        //ปุ่ม +
        private void button13_Click(object sender, EventArgs e)
        {
            //assign value to class variable
            this.input1 = Double.Parse(this.tb.Text);
            //clear input text
            this.tb.Text = "";
            this.operation = "+";
        }
        //ปุ่ม=
        private void button12_Click(object sender, EventArgs e)
        {
            double input2 = Double.Parse(this.tb.Text);
            double result = 0;
            if(this.operation == "+")
            {
                result = input1 + input2;
            }
            else if (this.operation == "-")
            {
                result = input1 - input2;
            }
            else if (this.operation == "*")
            {
                result = input1 * input2;
            }
            else if (this.operation == "/")
            {
                result = input1 / input2;
            }
            this.tb.Text = result.ToString();
        }
        //เลข9
        private void button4_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "9";
        }
        //เลข8
        private void button5_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "8";
        }
        //เลข7
        private void button2_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "7";
        }
        //เลข6
        private void button3_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "6";
        }
        //เลข5
        private void button6_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "5";
        }
        //เลข4
        private void button7_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "4";
        }
        //เลข3
        private void button10_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "3";
        }
        //เลข2
        private void button9_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "2";
        }
        //เลข1
        private void button8_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "1";
        }
        //เลข0
        private void button11_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "0";
        }
        //clear
        private void button13_Click_1(object sender, EventArgs e)
        {
            this.tb.Text = "";
        }
        //ปุ่ม -
        private void button14_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.tb.Text);
            this.tb.Text = "";
            this.operation = "-";
        }
        //ปุ่ม *
        private void button15_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.tb.Text);
            this.tb.Text = "";
            this.operation = "*";
        }
        //ปุ่ม /
        private void button16_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.tb.Text);
            this.tb.Text = "";
            this.operation = "/";
        }
        //ปุ่มdot
        private void button1_Click(object sender, EventArgs e)
        {
            if (!tb.Text.Contains(".")) 
            { tb.Text += "."; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double input2 = Double.Parse(this.tb_1.Text);
            double result = 0;
            if (this.operation == "+")
            {
                result = input1 + input2;
            }
            else if (this.operation == "-")
            {
                result = input1 - input2;
            }
            else if (this.operation == "*")
            {
                result = input1 * input2;
            }
            else if (this.operation == "/")
            {
                result = input1 / input2;
            }
            this.tb_1.Text = result.ToString();
        }
    }
}