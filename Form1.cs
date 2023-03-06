namespace calculator
{
    public partial class Form1 : Form
    {
        double result1;
        double result2;
        double result3;
        double result4;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result1 = 0;
            result2 = 0;    
            result3 = 0;
            result4 = 0;
            if(textBox1.Text !="" && textBox2.Text == "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Sin(box1);
                label4.Text = result1.ToString();

            }

            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Sin(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Sin(box2);
                result3 = result1 * result2;
                label4.Text = result3.ToString();
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Sin(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Sin(box2);
                double box3 = double.Parse(textBox3.Text);
                result3 = Math.Sin(box2);
                result4 = result1 * result2 * result3;
                label4.Text = result4.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            result1 = 0;
            result2 = 0;
            result3 = 0;
            result4 = 0;
            if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Cos(box1);
                label4.Text = result1.ToString();

            }

            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Cos(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Cos(box2);
                result3 = result1 * result2;
                label4.Text = result3.ToString();
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Cos(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Cos(box2);
                double box3 = double.Parse(textBox3.Text);
                result3 = Math.Cos(box2);
                result4 = result1 * result2 * result3;
                label4.Text = result4.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result1 = 0;
            result2 = 0;
            result3 = 0;
            result4 = 0;
            if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Tan(box1);
                label4.Text = result1.ToString();

            }

            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Tan(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Tan(box2);
                result3 = result1 * result2;
                label4.Text = result3.ToString();
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Tan(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Tan(box2);
                double box3 = double.Parse(textBox3.Text);
                result3 = Math.Tan(box2);
                result4 = result1 * result2 * result3;
                label4.Text = result4.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            result1 = 0;
            result2 = 0;
            result3 = 0;
            result4 = 0;
            if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Exp(box1);
                label4.Text = result1.ToString();

            }

            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Exp(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Exp(box2);
                result3 = result1 * result2;
                label4.Text = result3.ToString();
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
            {
                double box1 = double.Parse(textBox1.Text);
                result1 = Math.Exp(box1);
                double box2 = double.Parse(textBox2.Text);
                result2 = Math.Exp(box2);
                double box3 = double.Parse(textBox3.Text);
                result3 = Math.Exp(box2);
                result4 = result1 * result2 * result3;
                label4.Text = result4.ToString();
            }

        }
    }
}