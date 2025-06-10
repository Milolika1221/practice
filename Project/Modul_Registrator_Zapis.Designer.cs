namespace Project
{
    partial class Modul_Registrator_Zapis
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
            button4 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label7 = new Label();
            button5 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            comboBox2 = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            comboBox4 = new ComboBox();
            label13 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1343, 85);
            panel1.TabIndex = 10;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(1184, 14);
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
            label3.Location = new Point(1034, 51);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 5;
            label3.Text = "Регистратор";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1034, 14);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Пользователь";
            label2.Click += label2_Click;
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
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.InactiveCaption;
            button4.Location = new Point(690, 617);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(653, 153);
            button4.TabIndex = 11;
            button4.Text = "Бланк";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Location = new Point(0, 617);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(692, 153);
            button2.TabIndex = 9;
            button2.Text = "Запись";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1063, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 27);
            textBox1.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(950, 96);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 27;
            label7.Text = "*ФИО пациента";
            // 
            // button5
            // 
            button5.Location = new Point(1155, 514);
            button5.Name = "button5";
            button5.Size = new Size(164, 76);
            button5.TabIndex = 26;
            button5.Text = "Удалить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(964, 514);
            button3.Name = "button3";
            button3.Size = new Size(164, 76);
            button3.TabIndex = 25;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column8, Column9, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(12, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 30;
            dataGridView1.Size = new Size(932, 488);
            dataGridView1.TabIndex = 24;
            // 
            // Column1
            // 
            Column1.HeaderText = "ФИО пациента";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 103;
            // 
            // Column2
            // 
            Column2.HeaderText = "Дата рождения";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 103;
            // 
            // Column3
            // 
            Column3.HeaderText = "Номер телефона";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 103;
            // 
            // Column4
            // 
            Column4.HeaderText = "Спец. врача";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 103;
            // 
            // Column8
            // 
            Column8.HeaderText = "Врач";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 103;
            // 
            // Column9
            // 
            Column9.HeaderText = "Дата и время";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ToolTipText = "Lfn";
            Column9.Width = 103;
            // 
            // Column5
            // 
            Column5.HeaderText = "Аллергия";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 103;
            // 
            // Column6
            // 
            Column6.HeaderText = "Действ. заболевание";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 103;
            // 
            // Column7
            // 
            Column7.HeaderText = "Тип приёма";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 103;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(950, 138);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 29;
            label4.Text = "*Дата рождения";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1075, 177);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 27);
            textBox3.TabIndex = 32;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(946, 180);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 31;
            label5.Text = "*Номер телефона";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(950, 217);
            label8.Name = "label8";
            label8.Size = new Size(129, 40);
            label8.TabIndex = 35;
            label8.Text = "*Специализация \r\nврача";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Главный врач", "Терапевт", "Педиатр" });
            comboBox1.Location = new Point(1075, 217);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(256, 28);
            comboBox1.TabIndex = 37;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1063, 352);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(268, 27);
            textBox5.TabIndex = 39;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(950, 355);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 38;
            label9.Text = "Аллергия";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1063, 395);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(268, 27);
            textBox6.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(950, 395);
            label10.Name = "label10";
            label10.Size = new Size(105, 40);
            label10.TabIndex = 40;
            label10.Text = "Действующие\r\nзаболевания";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Первичный", "Повторный", "" });
            comboBox2.Location = new Point(1063, 437);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(268, 28);
            comboBox2.TabIndex = 43;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(950, 440);
            label11.Name = "label11";
            label11.Size = new Size(99, 20);
            label11.TabIndex = 42;
            label11.Text = "*Тип приёма";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(958, 263);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 44;
            label12.Text = "*Врач";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(1063, 305);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(268, 28);
            comboBox4.TabIndex = 47;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(950, 308);
            label13.Name = "label13";
            label13.Size = new Size(108, 20);
            label13.TabIndex = 46;
            label13.Text = "*Дата и время";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1071, 256);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(256, 27);
            textBox4.TabIndex = 48;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(1005, 478);
            label6.Name = "label6";
            label6.Size = new Size(277, 20);
            label6.TabIndex = 49;
            label6.Text = "Поля с * обязательны для заполнения";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1071, 133);
            dateTimePicker1.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(260, 27);
            dateTimePicker1.TabIndex = 50;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Modul_Registrator_Zapis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 769);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(comboBox4);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(comboBox2);
            Controls.Add(label11);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Modul_Registrator_Zapis";
            Text = "Modul_Registrator";
            FormClosing += Modul_Registrator_FormClosing;
            Load += Modul_Registrator_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e) => throw new NotImplementedException();

        #endregion

        private Panel panel1;
        private Button ExitButton;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Button button4;
        private Button button2;
        private TextBox textBox1;
        private Label label7;
        private Button button5;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label8;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private ComboBox comboBox2;
        private Label label11;
        private Label label12;
        private ComboBox comboBox4;
        private Label label13;
        private TextBox textBox4;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}