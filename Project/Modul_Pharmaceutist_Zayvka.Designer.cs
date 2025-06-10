
namespace Project
{
    partial class Modul_Pharmaceutist_Zayvka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            ExitButton = new Button();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button3 = new Button();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 33);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "ЛОГОТИП";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 85);
            panel1.TabIndex = 17;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(960, 15);
            ExitButton.Margin = new Padding(3, 4, 3, 4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(135, 57);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(797, 55);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "Фармацевт";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(797, 15);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Пользователь";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(137, 85);
            panel2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Location = new Point(556, 615);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(557, 153);
            button1.TabIndex = 15;
            button1.Text = "Лекарства";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Location = new Point(0, 615);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(557, 153);
            button2.TabIndex = 16;
            button2.Text = "Заявки";
            button2.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(556, 230);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(379, 27);
            numericUpDown1.TabIndex = 35;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox4
            // 
            textBox4.Location = new Point(556, 284);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(379, 27);
            textBox4.TabIndex = 34;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(556, 343);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(379, 27);
            textBox2.TabIndex = 33;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(556, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(379, 27);
            textBox1.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveCaption;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(259, 332);
            label4.Name = "label4";
            label4.Size = new Size(83, 38);
            label4.TabIndex = 31;
            label4.Text = "Цена";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.InactiveCaption;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(259, 273);
            label5.Name = "label5";
            label5.Size = new Size(155, 38);
            label5.TabIndex = 30;
            label5.Text = "Дозировка";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.InactiveCaption;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(259, 219);
            label6.Name = "label6";
            label6.Size = new Size(166, 38);
            label6.TabIndex = 29;
            label6.Text = "Количество";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.InactiveCaption;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(259, 167);
            label7.Name = "label7";
            label7.Size = new Size(274, 38);
            label7.TabIndex = 28;
            label7.Text = "Название лекарства";
            label7.Click += label7_Click;
            // 
            // button3
            // 
            button3.Location = new Point(418, 418);
            button3.Name = "button3";
            button3.Size = new Size(315, 76);
            button3.TabIndex = 27;
            button3.Text = "Сохранить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Location = new Point(205, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(734, 390);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Modul_Pharmaceutist_Zayvka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1113, 769);
            Controls.Add(numericUpDown1);
            Controls.Add(panel1);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "Modul_Pharmaceutist_Zayvka";
            Text = "Modul_Pharmaceutist_Zayvka";
            FormClosing += Modul_Pharmaceutist_Zayvka_FormClosing;
            Load += Modul_Pharmaceutist_Zayvka_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label7_Click(object sender, EventArgs e) => throw new NotImplementedException();

        private void label6_Click(object sender, EventArgs e) => throw new NotImplementedException();

        private void label5_Click(object sender, EventArgs e) => throw new NotImplementedException();

        private void label4_Click(object sender, EventArgs e) => throw new NotImplementedException();

        private void textBox1_TextChanged(object sender, EventArgs e) => throw new NotImplementedException();

        #endregion

        private Label label1;
        private Panel panel1;
        private Button ExitButton;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button3;
        private GroupBox groupBox1;
    }
}