namespace Library_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("กรุณาใส่ชื่อผู้ใช้", "ผิดพลาด");
                }
                else 
                {
                    textBox2.Focus();
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //ครู
                if (textBox1.Text != "teacher" && textBox2.Text != "55555")
                {
                    MessageBox.Show("กรุณาใส่ชื่อผู้ใช้", "ผิดพลาด");
                    textBox2.Clear();
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else if (textBox1.Text == "teacher" && textBox2.Text == "55555")
                {
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("รหัสผิดพลาด", "ผิดพลาด");
                    textBox2.Clear();
                    textBox2.Focus();
                }
                //น.ศ.
                if (textBox1.Text != "student" && textBox2.Text != "55555")
                {
                    MessageBox.Show("กรุณาใส่ชื่อผู้ใช้", "ผิดพลาด");
                    textBox2.Clear();
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else if (textBox1.Text == "student" && textBox2.Text == "55555")
                {
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("รหัสผิดพลาด", "ผิดพลาด");
                    textBox2.Clear();
                    textBox2.Focus();
                }
                //สตาฟ
                if (textBox1.Text != "staff" && textBox2.Text != "55555")
                {
                    MessageBox.Show("กรุณาใส่ชื่อผู้ใช้", "ผิดพลาด");
                    textBox2.Clear();
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else if (textBox1.Text == "staff" && textBox2.Text == "55555")
                {
                    this.Hide();
                    Form3 f3 = new Form3();
                    f3.Show();
                }
                else
                {
                    MessageBox.Show("รหัสผิดพลาด", "ผิดพลาด");
                    textBox2.Clear();
                    textBox2.Focus();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ขอบคุณที่ใช้บริการครับ", "ปิดโปรแกรม");
            Close();
        }
    }
}