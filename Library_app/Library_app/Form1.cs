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
                    MessageBox.Show("��س������ͼ����", "�Դ��Ҵ");
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
                //���
                if (textBox1.Text != "teacher" && textBox2.Text != "55555")
                {
                    MessageBox.Show("��س������ͼ����", "�Դ��Ҵ");
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
                    MessageBox.Show("���ʼԴ��Ҵ", "�Դ��Ҵ");
                    textBox2.Clear();
                    textBox2.Focus();
                }
                //�.�.
                if (textBox1.Text != "student" && textBox2.Text != "55555")
                {
                    MessageBox.Show("��س������ͼ����", "�Դ��Ҵ");
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
                    MessageBox.Show("���ʼԴ��Ҵ", "�Դ��Ҵ");
                    textBox2.Clear();
                    textBox2.Focus();
                }
                //ʵҿ
                if (textBox1.Text != "staff" && textBox2.Text != "55555")
                {
                    MessageBox.Show("��س������ͼ����", "�Դ��Ҵ");
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
                    MessageBox.Show("���ʼԴ��Ҵ", "�Դ��Ҵ");
                    textBox2.Clear();
                    textBox2.Focus();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�ͺ�س������ԡ�ä�Ѻ", "�Դ�����");
            Close();
        }
    }
}