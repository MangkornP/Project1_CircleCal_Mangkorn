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
                txtRadius.Focus();
                return;
            }
            double Radius = 0, pi = 3.14, sum = 0;
            Radius = Convert.ToDouble(txtRadius.Text);
            sum = pi * Radius * Radius;
            lbRadius.Text = sum.ToString("");
        }
    }
}