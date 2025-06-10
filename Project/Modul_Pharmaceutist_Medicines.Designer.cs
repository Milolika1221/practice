namespace Project
{
    partial class Modul_Pharmaceutist_Medicines
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
            panel1 = new Panel();
            ExitButton = new Button();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button5 = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 85);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 33);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "ЛОГОТИП";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Location = new Point(556, 614);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(557, 153);
            button1.TabIndex = 12;
            button1.Text = "Лекарства";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Location = new Point(0, 614);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(557, 153);
            button2.TabIndex = 13;
            button2.Text = "Заявки";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(12, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(710, 488);
            dataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            Column1.HeaderText = "Название лекарства";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 164;
            // 
            // Column2
            // 
            Column2.HeaderText = "Количество";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 164;
            // 
            // Column3
            // 
            Column3.HeaderText = "Дозировка";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 164;
            // 
            // Column4
            // 
            Column4.HeaderText = "Цена";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 164;
            // 
            // button3
            // 
            button3.Location = new Point(740, 292);
            button3.Name = "button3";
            button3.Size = new Size(164, 76);
            button3.TabIndex = 16;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(931, 292);
            button5.Name = "button5";
            button5.Size = new Size(164, 76);
            button5.TabIndex = 18;
            button5.Text = "Удалить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(887, 155);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(211, 27);
            numericUpDown1.TabIndex = 26;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox4
            // 
            textBox4.Location = new Point(884, 195);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(211, 27);
            textBox4.TabIndex = 25;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(884, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 27);
            textBox2.TabIndex = 24;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(887, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(731, 236);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 22;
            label4.Text = "Цена";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(731, 202);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 21;
            label5.Text = "Дозировка";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(731, 165);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 20;
            label6.Text = "Количество";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(731, 117);
            label7.Name = "label7";
            label7.Size = new Size(150, 20);
            label7.TabIndex = 19;
            label7.Text = "Название лекарства";
            // 
            // Modul_Pharmaceutist_Medicines
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1113, 769);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(button2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Modul_Pharmaceutist_Medicines";
            Text = "Modul_Pharmaceutist";
            FormClosing += Modul_Pharmaceutist_Medicines_FormClosing;
            Load += Modul_Pharmaceutist_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button ExitButton;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button3;
        private Button button5;
        private NumericUpDown numericUpDown1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}