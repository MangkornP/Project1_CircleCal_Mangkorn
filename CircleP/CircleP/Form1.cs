namespace CircleP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRadius.Text == "")
            {
                MessageBox.Show("��سһ�͹����Ţ����ա�͹", "����͹");
            }
            }

        private void btClr_Click(object sender, EventArgs e)
        {
           
        }

        private void btExit_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}