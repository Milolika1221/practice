
namespace Project
{
    partial class Modul_ManagerFood_Order
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
            button3 = new Button();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 85);
            panel1.TabIndex = 20;
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
            button1.Location = new Point(554, 616);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(557, 153);
            button1.TabIndex = 18;
            button1.Text = "Продукты";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Location = new Point(1, 616);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(557, 153);
            button2.TabIndex = 19;
            button2.Text = "Заказ";
            button2.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(548, 203);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(379, 27);
            numericUpDown1.TabIndex = 45;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox2
            // 
            textBox2.Location = new Point(351, 260);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(379, 27);
            textBox2.TabIndex = 43;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(548, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(379, 27);
            textBox1.TabIndex = 42;
            // 
            // button3
            // 
            button3.Location = new Point(211, 326);
            button3.Name = "button3";
            button3.Size = new Size(315, 76);
            button3.TabIndex = 37;
            button3.Text = "Сохранить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveCaption;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(54, 249);
            label4.Name = "label4";
            label4.Size = new Size(83, 38);
            label4.TabIndex = 41;
            label4.Text = "Цена";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.InactiveCaption;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(52, 24);
            label7.Name = "label7";
            label7.Size = new Size(263, 38);
            label7.TabIndex = 38;
            label7.Text = "Название продукта";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.InactiveCaption;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(52, 130);
            label5.Name = "label5";
            label5.Size = new Size(256, 38);
            label5.TabIndex = 40;
            label5.Text = "Дата изготовления";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.InactiveCaption;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(52, 75);
            label6.Name = "label6";
            label6.Size = new Size(166, 38);
            label6.TabIndex = 39;
            label6.Text = "Количество";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(197, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(734, 426);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(351, 199);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(377, 27);
            dateTimePicker2.TabIndex = 49;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(351, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(377, 27);
            dateTimePicker1.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.InactiveCaption;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(52, 190);
            label8.Name = "label8";
            label8.Size = new Size(202, 38);
            label8.TabIndex = 47;
            label8.Text = "Срок годности";
            // 
            // Modul_ManagerFood_Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1113, 769);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Modul_ManagerFood_Order";
            Text = "Modul_ManagerFood_Order";
            FormClosing += Modul_ManagerFood_Order_FormClosing;
            Load += Modul_ManagerFood_Order_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label8_Click(object sender, EventArgs e) => throw new NotImplementedException();

        private void textBox3_TextChanged(object sender, EventArgs e) => throw new NotImplementedException();

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
        private Button button3;
        private Label label4;
        private Label label7;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Label label8;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
    }
}