
namespace Project
{
    partial class Modul_MainDoctor_Zayvka
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
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            ExitButton = new Button();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button6 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(1114, 85);
            panel1.TabIndex = 6;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(960, 14);
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
            label3.Location = new Point(788, 51);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 5;
            label3.Text = "Главный врач";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(787, 14);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Пользователь";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Location = new Point(0, 617);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(377, 153);
            button2.TabIndex = 5;
            button2.Text = "Заявки";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Location = new Point(369, 617);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(377, 153);
            button1.TabIndex = 4;
            button1.Text = "Записи";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.InactiveCaption;
            button4.Location = new Point(737, 617);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(377, 153);
            button4.TabIndex = 7;
            button4.Text = "Расписание";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(931, 387);
            button5.Name = "button5";
            button5.Size = new Size(164, 76);
            button5.TabIndex = 29;
            button5.Text = "Удалить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(12, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(913, 488);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Название лекарства";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 224;
            // 
            // Column2
            // 
            Column2.HeaderText = "Количество";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 224;
            // 
            // Column3
            // 
            Column3.HeaderText = "Дозировка";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 224;
            // 
            // Column4
            // 
            Column4.HeaderText = "Цена";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 224;
            // 
            // button6
            // 
            button6.Location = new Point(931, 198);
            button6.Name = "button6";
            button6.Size = new Size(164, 76);
            button6.TabIndex = 38;
            button6.Text = "Оформить";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Modul_MainDoctor_Zayvka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1113, 769);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Modul_MainDoctor_Zayvka";
            Text = "Modul_MainDoctor";
            FormClosing += Modul_MainDoctor_Zayvka_FormClosing;
            Load += Modul_MainDoctor_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void Modul_MainDoctor_Zayvka_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button ExitButton;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private Button button6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}