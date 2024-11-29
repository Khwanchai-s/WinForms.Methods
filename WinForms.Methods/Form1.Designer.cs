namespace WinForms.Methods
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(168, 9);
            label1.Name = "label1";
            label1.Size = new Size(401, 54);
            label1.TabIndex = 0;
            label1.Text = "โปรแกรมคำนวณค่า BMI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 271);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 1;
            label2.Text = "น้ำหนัก (kg)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 114);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 2;
            label3.Text = "ชื่อ-นามสกุล";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(339, 34);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 271);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 34);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 173);
            label4.Name = "label4";
            label4.Size = new Size(42, 28);
            label4.TabIndex = 2;
            label4.Text = "อายุ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(128, 34);
            textBox3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 225);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 2;
            label5.Text = "ส่วนสูง (cm)";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(128, 34);
            textBox4.TabIndex = 3;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(255, 224, 192);
            label6.Font = new Font("Segoe UI", 24F);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(12, 341);
            label6.Name = "label6";
            label6.Size = new Size(748, 315);
            label6.TabIndex = 5;
            label6.Text = "...";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(537, 167);
            button1.Name = "button1";
            button1.Size = new Size(197, 120);
            button1.TabIndex = 6;
            button1.Text = "ค่า BMI";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 675);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "โปรแกรมคำนวณค่า BMI  (เรื่อง Method/Function)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Button button1;
    }
}
