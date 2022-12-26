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

        //���� +
        private void button13_Click(object sender, EventArgs e)
        {
            //assign value to class variable
            this.input1 = Double.Parse(this.tb.Text);
            //clear input text
            this.tb.Text = "";
            this.operation = "+";
        }
        //����=
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
        //�Ţ9
        private void button4_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "9";
        }
        //�Ţ8
        private void button5_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "8";
        }
        //�Ţ7
        private void button2_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "7";
        }
        //�Ţ6
        private void button3_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "6";
        }
        //�Ţ5
        private void button6_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "5";
        }
        //�Ţ4
        private void button7_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "4";
        }
        //�Ţ3
        private void button10_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "3";
        }
        //�Ţ2
        private void button9_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "2";
        }
        //�Ţ1
        private void button8_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "1";
        }
        //�Ţ0
        private void button11_Click(object sender, EventArgs e)
        {
            this.tb.Text = this.tb.Text + "0";
        }
        //clear
        private void button13_Click_1(object sender, EventArgs e)
        {
            this.tb.Text = "";
        }
        //���� -
        private void button14_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.tb.Text);
            this.tb.Text = "";
            this.operation = "-";
        }
        //���� *
        private void button15_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.tb.Text);
            this.tb.Text = "";
            this.operation = "*";
        }
        //���� /
        private void button16_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.tb.Text);
            this.tb.Text = "";
            this.operation = "/";
        }
        //����dot
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