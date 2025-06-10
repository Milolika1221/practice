using Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Modul_MainDoctor_Schedule : Form
    {
        private Role_MainDoctor doctor;
        public Modul_MainDoctor_Schedule()
        {
            InitializeComponent();
            doctor = new Role_MainDoctor(dataGridView1);
        }

        private void Modul_MainDoctor_Schedule_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private Modul_MainDoctor_Zapis zapis;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (zapis != null)
                zapis.Show();
            else
            {
                zapis = new Modul_MainDoctor_Zapis();
                zapis.SetName = Name;
                zapis.Show();
            }
        }
        private static string Name;
        public string SetName
        {
            get { return Name; }
            set { Name = value; }
        }
        private void Modul_MainDoctor_Schedule_Load(object sender, EventArgs e)
        {
            label2.Text = Name;
            doctor.AddDefaultShedule();
        }
        private Authorisation authorFrm;
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            authorFrm = new Authorisation();
            authorFrm.Show();
        }
        private Modul_MainDoctor_Zayvka zayvka;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (zayvka != null)
            {
                zayvka.Show();
            }
            else
            {
                zayvka = new Modul_MainDoctor_Zayvka();
                zayvka.SetName = Name;
                zayvka.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
