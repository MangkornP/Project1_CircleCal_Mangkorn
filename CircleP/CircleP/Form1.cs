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
            if (txtRadius.Text == "")//ข้อความแจ้งเตือนให้ใส่ตัวเลข กาว
            {
                MessageBox.Show("กรุณาป้อนตัวเลขรัศมีก่อน", "แจ้งเตือน");//ข้อความแจ้งเตือนให้ใส่ตัวเลข กาว
            }
            }

        private void btClr_Click(object sender, EventArgs e)
        {
           
        }

        private void btExit_Click(object sender, EventArgs e)
        {
           
        }
    }
}