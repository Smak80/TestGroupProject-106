namespace TestGroupProject_106
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Makletsov sv = new Makletsov();
            label1.Text = sv.ToString();
        }
    }
}