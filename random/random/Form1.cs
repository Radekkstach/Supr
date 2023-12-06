namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int random = (int)numericUpDown1.Value;
            Random rnd = new Random();
            label1.Text = rnd.Next(1,random+1).ToString();
        }
    }
}