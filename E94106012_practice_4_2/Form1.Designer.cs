namespace E94106012_practice_4_1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            NumList = new ImageList(components);
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            unlock = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ImageList = NumList;
            button1.Location = new Point(152, 160);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(144, 208);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NumList
            // 
            NumList.ColorDepth = ColorDepth.Depth8Bit;
            NumList.ImageStream = (ImageListStreamer)resources.GetObject("NumList.ImageStream");
            NumList.TransparentColor = Color.Transparent;
            NumList.Images.SetKeyName(0, "0.jpg");
            NumList.Images.SetKeyName(1, "1.jpg");
            NumList.Images.SetKeyName(2, "2.jpg");
            NumList.Images.SetKeyName(3, "3.jpg");
            NumList.Images.SetKeyName(4, "4.jpg");
            NumList.Images.SetKeyName(5, "5.jpg");
            NumList.Images.SetKeyName(6, "6.jpg");
            NumList.Images.SetKeyName(7, "7.jpg");
            NumList.Images.SetKeyName(8, "8.jpg");
            NumList.Images.SetKeyName(9, "9.jpg");
            // 
            // button2
            // 
            button2.ImageList = NumList;
            button2.Location = new Point(372, 160);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(144, 208);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ImageList = NumList;
            button3.Location = new Point(592, 160);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(144, 208);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ImageList = NumList;
            button4.Location = new Point(812, 160);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(144, 208);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // unlock
            // 
            unlock.Location = new Point(482, 592);
            unlock.Margin = new Padding(4, 5, 4, 5);
            unlock.Name = "unlock";
            unlock.Size = new Size(141, 55);
            unlock.TabIndex = 4;
            unlock.Text = "解鎖";
            unlock.UseVisualStyleBackColor = true;
            unlock.Click += unlock_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("新細明體", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(207, 104);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 38);
            label1.TabIndex = 5;
            label1.Text = "?";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("新細明體", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(427, 104);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(33, 38);
            label2.TabIndex = 6;
            label2.Text = "?";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("新細明體", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(647, 104);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 38);
            label3.TabIndex = 7;
            label3.Text = "?";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("新細明體", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(867, 104);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(33, 38);
            label4.TabIndex = 8;
            label4.Text = "?";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 800);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(unlock);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ImageList NumList;
        private Button unlock;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

