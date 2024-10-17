using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E94106012_practice_4_1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // �O����ʼ���o�DƬ
            button1.ImageIndex = 0;
            button2.ImageIndex = 0;
            button3.ImageIndex = 0;
            button4.ImageIndex = 0;

            // �a���S�C�ܴa
            Random rand = new Random();
            button1.Tag = rand.Next(10);
            button2.Tag = rand.Next(10);
            button3.Tag = rand.Next(10);
            button4.Tag = rand.Next(10);

            LabelClear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.ImageIndex == 9)
            {
                button1.ImageIndex = 0;
            }
            else
            {
                button1.ImageIndex += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.ImageIndex == 9)
            {
                button2.ImageIndex = 0;
            }
            else
            {
                button2.ImageIndex += 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.ImageIndex == 9)
            {
                button3.ImageIndex = 0;
            }
            else
            {
                button3.ImageIndex += 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.ImageIndex == 9)
            {
                button4.ImageIndex = 0;
            }
            else
            {
                button4.ImageIndex += 1;
            }
        }

        private void unlock_Click(object sender, EventArgs e)
        {
            if (button1.ImageIndex == (int)button1.Tag &&
                button2.ImageIndex == (int)button2.Tag &&
                button3.ImageIndex == (int)button3.Tag &&
                button4.ImageIndex == (int)button4.Tag)
            {
                LabelClear();
                MessageBox.Show("���i�ɹ�", "�ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                int count = 0;

                if (button1.ImageIndex == (int)button1.Tag)
                {
                    count++;
                    label1.Text = "��";
                }
                else
                {
                    label1.Text = "�e";
                }

                if (button2.ImageIndex == (int)button2.Tag)
                {
                    count++;
                    label2.Text = "��";
                }
                else
                {
                    label2.Text = "�e";
                }

                if (button3.ImageIndex == (int)button3.Tag)
                {
                    count++;
                    label3.Text = "��";
                }
                else
                {
                    label3.Text = "�e";
                }

                if (button4.ImageIndex == (int)button4.Tag)
                {
                    count++;
                    label4.Text = "��";
                }
                else
                {
                    label4.Text = "�e";
                }

                DialogResult result;
                result = MessageBox.Show("��" + count + "��λ��", "ʧ��", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show($"����{button1.Tag}{button2.Tag}{button3.Tag}{button4.Tag}", "", MessageBoxButtons.OK);
                }
            }
        }

        // �������
        public void LabelClear()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
