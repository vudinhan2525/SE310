namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddBtn = new Button();
            button2 = new Button();
            button3 = new Button();
            TiengKeuBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(142, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 42);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 3;
            label1.Text = "Số lượng bò:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 139);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 4;
            label2.Text = "Số lượng dê:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 87);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 5;
            label3.Text = "Số lượng cừu:";
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(100, 207);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(167, 29);
            AddBtn.TabIndex = 6;
            AddBtn.Text = "Thêm số lượng";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(317, 211);
            button2.Name = "button2";
            button2.Size = new Size(167, 29);
            button2.TabIndex = 7;
            button2.Text = "Sinh con";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(526, 211);
            button3.Name = "button3";
            button3.Size = new Size(167, 29);
            button3.TabIndex = 8;
            button3.Text = "Thống kê";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TiengKeuBtn
            // 
            TiengKeuBtn.Location = new Point(100, 259);
            TiengKeuBtn.Name = "TiengKeuBtn";
            TiengKeuBtn.Size = new Size(167, 29);
            TiengKeuBtn.TabIndex = 9;
            TiengKeuBtn.Text = "Tiếng kêu";
            TiengKeuBtn.UseVisualStyleBackColor = true;
            TiengKeuBtn.Click += TiengKeuBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 320);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 359);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 394);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(380, 38);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(380, 94);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(380, 146);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TiengKeuBtn);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(AddBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddBtn;
        private Button button2;
        private Button button3;
        private Button TiengKeuBtn;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
