namespace fordiscord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = this;
            form1.Text = textBox1.Text;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MessageBox.Show("The program will run in the background. to completely close it, close it in the task manager", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form form = this;
            form.Hide();
            e.Cancel = true;
        }
                         
      

    }
}