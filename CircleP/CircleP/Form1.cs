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
            if (txtRadius.Text == "")//��ͤ�������͹���������Ţ ���
            {
                MessageBox.Show("��سһ�͹����Ţ����ա�͹", "����͹");//��ͤ�������͹���������Ţ ���
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