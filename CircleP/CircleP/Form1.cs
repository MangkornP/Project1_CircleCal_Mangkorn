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
                MessageBox.Show("กรุณาป้อนตัวเลขรัศมีก่อน", "แจ้งเตือน");
                txtRadius.Focus();
                return;
            }
            double Radius = 0, pi = 3.14, sum = 0;
            Radius = Convert.ToDouble(txtRadius.Text);
            lbRadius.Text = sum.ToString("");
        }

        private void btClr_Click(object sender, EventArgs e)
        {
           
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}