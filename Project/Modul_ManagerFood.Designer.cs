namespace Project
{
    partial class Modul_ManagerFood
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
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button5 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(1110, 85);
            panel1.TabIndex = 17;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(966, 13);
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
            label3.Location = new Point(767, 50);
            label3.Name = "label3";
            label3.Size = new Size(193, 20);
            label3.TabIndex = 5;
            label3.Text = "Заведующий пищеблоком";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(823, 13);
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
            button1.Location = new Point(553, 616);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(557, 153);
            button1.TabIndex = 15;
            button1.Text = "Продукты";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Location = new Point(0, 616);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(557, 153);
            button2.TabIndex = 16;
            button2.Text = "Заказ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(884, 184);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(211, 27);
            numericUpDown1.TabIndex = 37;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox2
            // 
            textBox2.Location = new Point(881, 308);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 27);
            textBox2.TabIndex = 35;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(884, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(737, 311);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 33;
            label4.Text = "Цена";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(737, 231);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 32;
            label5.Text = "Дата изготовления";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(737, 194);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 31;
            label6.Text = "Количество";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(737, 146);
            label7.Name = "label7";
            label7.Size = new Size(144, 20);
            label7.TabIndex = 30;
            label7.Text = "Название продукта";
            // 
            // button5
            // 
            button5.Location = new Point(928, 372);
            button5.Name = "button5";
            button5.Size = new Size(164, 76);
            button5.TabIndex = 29;
            button5.Text = "Удалить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(737, 372);
            button3.Name = "button3";
            button3.Size = new Size(164, 76);
            button3.TabIndex = 28;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4 });
            dataGridView1.Location = new Point(3, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(728, 488);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Название продукта";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 135;
            // 
            // Column2
            // 
            Column2.HeaderText = "Количество";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 135;
            // 
            // Column3
            // 
            Column3.HeaderText = "Дата изготовления";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 135;
            // 
            // Column5
            // 
            Column5.HeaderText = "Срок годности";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 135;
            // 
            // Column4
            // 
            Column4.HeaderText = "Цена";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 135;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(737, 273);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 38;
            label8.Text = "Срок годности";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(881, 224);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 27);
            dateTimePicker1.TabIndex = 40;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(881, 268);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(220, 27);
            dateTimePicker2.TabIndex = 41;
            // 
            // Modul_ManagerFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1113, 769);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(numericUpDown1);
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
            Name = "Modul_ManagerFood";
            Text = "Modul_ManagerFood";
            FormClosing += Modul_ManagerFood_FormClosing;
            Load += Modul_ManagerFood_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button5;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}