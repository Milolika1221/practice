using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Office2013.WebExtentionPane;
using Project.Classes;

namespace Project
{
    public partial class Modul_ManagerFood_Order : Form
    {
        private Role_ManagerFood managerFood;
        public Modul_ManagerFood_Order()
        {
            InitializeComponent();
            managerFood = new Role_ManagerFood();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (!isInt)
            {
                MessageBox.Show("Неправильный формат для поля 'Цена'");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text) || numericUpDown1.Value == null || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            managerFood.CreateOrder(textBox1.Text, dateTimePicker1.Text, dateTimePicker2.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(textBox2.Text));
            textBox1.Text = ""; textBox2.Text = ""; numericUpDown1.Value = 1;

        }
        private Modul_ManagerFood food;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (food != null)
                food.Show();
            else
            {
                food = new Modul_ManagerFood();
                food.SetName = Name;
                food.Show();
            }
        }
        private Authorisation authorFrm;
        private void Modul_ManagerFood_Order_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

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
        private static string Name;
        public string SetName
        {
            get { return Name; }
            set { Name = value; }
        }
        private void Modul_ManagerFood_Order_Load(object sender, EventArgs e) => label2.Text = Name;
        private bool isInt = false;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int number2))
            {
                isInt = false;
                return;
            }
            isInt = true;
        }
    }
}
