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
using System.Xml;

namespace Project
{
    public partial class Modul_MainDoctor_Zapis : Form
    {
        public Modul_MainDoctor_Zapis()
        {
            InitializeComponent();
            doctor = new Role_MainDoctor(dataGridView1);
        }
        private static string Name;
        public string SetName
        {
            get { return Name; }
            set { Name = value; }
        }

        private Role_MainDoctor doctor;
        private void Modul_MainDoctor_Zapis_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
        private Authorisation authorFrm;
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            authorFrm = new Authorisation();
            authorFrm.Show();
        }
        private Role_Registrator registrator;
        private void LoadFromXml()
        {
            string filePath = "C:\\Users\\Кристина\\Desktop\\Project\\Project\\Zapises.xml";

            if (File.Exists(filePath))
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(filePath);
                    XmlNodeList zapisNodes = doc.SelectNodes("/Zapises/zapis");

                    if (zapisNodes != null)
                    {
                        dataGridView1.Rows.Clear();
                        foreach (XmlNode node in zapisNodes)
                        {
                            string name = node.Attributes["name"]?.Value;
                            string date = node.Attributes["date"]?.Value;
                            string numberPhone = node.Attributes["NumberPhone"]?.Value;
                            string SpecialDoctor = node.Attributes["SpecialDoctor"]?.Value;
                            string Doctor = node.Attributes["Doctor"]?.Value;
                            string DataTime = node.Attributes["DataAndTime"]?.Value;
                            string Allergia = node.Attributes["Allergia"]?.Value;
                            string Diseases = node.Attributes["Diseases"]?.Value;
                            string Type = node.Attributes["Type"]?.Value;

                            doctor.AddZapisToDoctor(name, date, numberPhone, SpecialDoctor, Doctor, DataTime, Allergia, Diseases, Type);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки XML: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Файл Zapises.xml не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Modul_MainDoctor_Zapis_Load(object sender, EventArgs e)
        {
            label2.Text = Name;
            doctor.AddDefaultPatient();
            LoadFromXml();


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
        private Modul_MainDoctor_Schedule shedule;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (shedule != null)
                shedule.Show();
            else
            {
                shedule = new Modul_MainDoctor_Schedule();
                shedule.SetName = Name;
                shedule.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
