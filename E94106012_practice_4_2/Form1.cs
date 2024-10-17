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
            // 設定初始按鈕圖片
            button1.ImageIndex = 0;
            button2.ImageIndex = 0;
            button3.ImageIndex = 0;
            button4.ImageIndex = 0;

            // 產生隨機密碼
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
                MessageBox.Show("解鎖成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                int count = 0;

                if (button1.ImageIndex == (int)button1.Tag)
                {
                    count++;
                    label1.Text = "對";
                }
                else
                {
                    label1.Text = "錯";
                }

                if (button2.ImageIndex == (int)button2.Tag)
                {
                    count++;
                    label2.Text = "對";
                }
                else
                {
                    label2.Text = "錯";
                }

                if (button3.ImageIndex == (int)button3.Tag)
                {
                    count++;
                    label3.Text = "對";
                }
                else
                {
                    label3.Text = "錯";
                }

                if (button4.ImageIndex == (int)button4.Tag)
                {
                    count++;
                    label4.Text = "對";
                }
                else
                {
                    label4.Text = "錯";
                }

                DialogResult result;
                result = MessageBox.Show("猜對" + count + "個位置", "失敗", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show($"答案是{button1.Tag}{button2.Tag}{button3.Tag}{button4.Tag}", "", MessageBoxButtons.OK);
                }
            }
        }

        // 清空文字
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
