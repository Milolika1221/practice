using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Classes;

namespace Project
{
    public partial class Modul_Pharmaceutist_Medicines : Form
    {
        private Role_Pharmaceutist pharm;
        public Modul_Pharmaceutist_Medicines()
        {
            InitializeComponent();
            pharm = new Role_Pharmaceutist(dataGridView1);
        }
        private static string Name;
        public string SetName
        {
            get { return Name; }
            set { Name = value; }
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isInt1)
            {
                MessageBox.Show("Неправильный формат для поля 'Дозировка'");
                return;
            }

            if (!isInt2)
            {
                MessageBox.Show("Неправильный формат для поля 'Цена'");
                return;
            }

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox4.Text) && numericUpDown1.Value > 0)
            {
                pharm.AddMedicine(textBox1.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox4.Text));
                textBox1.Text = ""; textBox2.Text = ""; textBox4.Text = ""; numericUpDown1.Value = 1;
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
                
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private Modul_Pharmaceutist_Zayvka zayvka;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (zayvka != null)
            {
                zayvka.Show();
            }
            else
            {
                zayvka = new Modul_Pharmaceutist_Zayvka();
                zayvka.SetName = Name;
                zayvka.Show();
            }
        }
        private void Modul_Pharmaceutist_Load(object sender, EventArgs e)
        {
            pharm.AddDefaultMedicines();
            label2.Text = Name;
        }

        private void button5_Click(object sender, EventArgs e) => pharm.RemoveSelectedMedicines();
        private void Modul_Pharmaceutist_Medicines_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool isInt1 = false;
        private bool isInt2 = false;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox4.Text, out int number2))
            {
                isInt1 = false;
                return;
            }
            isInt1 = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int number2))
            {
                isInt2 = false;
                return;
            }
            isInt2 = true;
        }
    }
    }

