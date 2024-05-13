namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string c;
        double x;
    

        private void button10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + b.Text;
            if (textBox1.Text == "." && b.Text == ".")
                textBox1.Text = "0.0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button b =(Button)sender;
            if (textBox1.Text != "" && label1.Text != "")
                button13.PerformClick();
            c = b.Text;
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "" + c;
            textBox1.Clear();
            if (textBox1.Text != "" && label1.Text != "") 
                button13.PerformClick();    
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch(c)
            {
                case "+":
                    {
                        double y = Convert.ToDouble(textBox1.Text); 
                        textBox1.Text = (x + y).ToString();
                        label1.Text = "";
                    }
                    break;
                case "-":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x - y).ToString();
                        label1.Text = "";
                    }
                    break;
                case "*":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x * y).ToString();
                        label1.Text = "";
                    }
                    break;
                case "/":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x / y).ToString();
                        label1.Text = "";
                    }
                    break;




            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case '+':
                    {
                        e.Handled = true;
                        button16.PerformClick();
                    }
                    break;
                case '-':
                    {
                        e.Handled = true;
                        button17.PerformClick();
                    }
                    break;
                case '*':
                    {
                        e.Handled = true;
                        button15.PerformClick();
                    }
                    break;
                case '/':
                    {
                        e.Handled = true;
                        button14.PerformClick();
                    }
                    break;
                case '=' :
                    {
                        e.Handled = true;
                        button13.PerformClick();
                       }
                    break;
                case (char)Keys.Back:
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("Enter The Number Only");
                    break;

            }

        }
    }
}