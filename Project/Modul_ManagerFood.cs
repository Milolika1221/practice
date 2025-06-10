using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Classes;

namespace Project
{
    public partial class Modul_ManagerFood : Form
    {
        private Role_ManagerFood managerFood;
        public Modul_ManagerFood()
        {
            InitializeComponent();
            managerFood = new Role_ManagerFood(dataGridView1);
        }
        Authorisation authorFrm;
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (authorFrm != null)
            {
                authorFrm.Show();
            }
            else
            {
                authorFrm = new Authorisation();
                authorFrm.Show();
            }
        }

        private void Modul_ManagerFood_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
        private bool isInt = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (!isInt)
            {
                MessageBox.Show("Неправильный формат для поля 'Цена'");
                return;
            }
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(dateTimePicker1.Text) && !string.IsNullOrEmpty(dateTimePicker2.Text) && numericUpDown1.Value > 0)
            {
                managerFood.AddFood(textBox1.Text, Convert.ToInt32(numericUpDown1.Value), dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(textBox2.Text));
                textBox1.Text = ""; textBox2.Text = ""; numericUpDown1.Value = 1;
            }
            else
                MessageBox.Show("Не все поля заполнены");
        }

        private void button5_Click(object sender, EventArgs e) => managerFood.RemoveSelectedFood();
        private static string Name;
        public string SetName
        {
            get { return Name; }
            set { Name = value; }
        }
        private void Modul_ManagerFood_Load(object sender, EventArgs e)
        {
            managerFood.AddDefaultFood();
            label2.Text = Name;
        }
        private Modul_ManagerFood_Order order;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (order != null)
                order.Show();
            else
            {
                order = new Modul_ManagerFood_Order();
                order.SetName = Name;
                order.Show();
            }

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int number2))
            {              
                isInt = false;
                return;
            }
            isInt = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
