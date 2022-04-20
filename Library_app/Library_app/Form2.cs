using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            if (radioButton1.Checked)
            {
                dataGridView1.Rows[n].Cells[0].Value = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                dataGridView1.Rows[n].Cells[0].Value = radioButton2.Text;
            }
            else
            {
                MessageBox.Show("กรุณาใส่ข้อมูลให้ครบถ้วน", "ผิดพลาด");
            }            
            dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = maskedTextBox1.Text;
            if (checkBox17.Checked)
            {
                dataGridView1.Rows[n].Cells[3].Value = checkBox17.Text;               
            }
            else if (checkBox18.Checked)
            {
                dataGridView1.Rows[n].Cells[3].Value = checkBox18.Text;
            }
            else if (checkBox19.Checked)
            {
                dataGridView1.Rows[n].Cells[3].Value = checkBox19.Text;
            }
            else
            {
                MessageBox.Show("กรุณาใส่ข้อมูลให้ครบถ้วน", "ผิดพลาด");
            }
            dataGridView1.Rows[n].Cells[4].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[5].Value = maskedTextBox2.Text;
            if (checkBox1.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value +="Book1" + ",";
            }
            if (checkBox2.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value += "Book2" + ",";
            }
            if (checkBox3.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value += "Book3" + ",";
            }
            if (checkBox4.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value += "Book4" + ",";
            }
            if (checkBox5.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value += "Book5" + ",";
            }
            if (checkBox6.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value += "Book6" + ",";
            }
            if (checkBox7.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value += "Book7" + ",";
            }
            if (checkBox8.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value += "Book8" + ",";
            }
            if (checkBox9.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value += "Book9" + ",";
            }
            if (checkBox10.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value += "Book10" + ",";
            }
            if (checkBox11.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value += "Book11" + ",";
            }
            if (checkBox12.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value += "Book12" + ",";
            }
            if (checkBox13.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value += "Book13" + ",";
            }
            if (checkBox14.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value += "Book14" + ",";
            }
            if (checkBox15.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value += "Book15" + ",";
            }
            if (checkBox16.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value += "Book16" + ",";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ขอบคุณที่ใช้บริการครับ", "ปิดโปรแกรม");
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += columnNames;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ผิดพลาด :" + ex.Message);
                        }
                    }
                }
            }
    }}
} 
