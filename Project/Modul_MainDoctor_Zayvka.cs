using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.VisualBasic.Logging;
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
    public partial class Modul_MainDoctor_Zayvka : Form
    {
        private Role_MainDoctor doctor;
        public Modul_MainDoctor_Zayvka()
        {
            InitializeComponent();
            doctor = new Role_MainDoctor(dataGridView1);
        }
        Authorisation authorFrm;

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            authorFrm = new Authorisation();
            authorFrm.Show();
        }
        private static string Name;
        public string SetName
        {
            get { return Name; }
            set { Name = value; }
        }
        private void Modul_MainDoctor_Load(object sender, EventArgs e)
        {
            label2.Text = Name;
            LoadFromXml();
        }
        private void RemoveZayvkaFromXml(string name, int count, int dozirovka, int price)
        {
            string filePath = "Zayvkas.xml";

            if (File.Exists(filePath))
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(filePath);
                    XmlNodeList zayvkaNodes = doc.SelectNodes("/Zayvkas/zayvka");
                    if (zayvkaNodes != null)
                    {
                        foreach (XmlNode node in zayvkaNodes)
                        {
                            if (node.Attributes["name"]?.Value == name &&
                                int.Parse(node.Attributes["count"]?.Value) == count &&
                                int.Parse(node.Attributes["dozirovka"]?.Value) == dozirovka &&
                                int.Parse(node.Attributes["price"]?.Value) == price)
                            {
                                node.ParentNode.RemoveChild(node);
                                break; // Удаляем первую подходящую заявку
                            }
                        }
                    }
                    doc.Save(filePath); // Сохраняем изменения
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении заявки из XML: {ex.Message}");
                }
            }
        }
        private void LoadFromXml()
        {
            string filePath = "Zayvkas.xml";

            if (File.Exists(filePath))
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(filePath);
                    XmlNodeList zayvkaNodes = doc.SelectNodes("/Zayvkas/zayvka");

                    if (zayvkaNodes != null)
                    {
                        dataGridView1.Rows.Clear();
                        foreach (XmlNode node in zayvkaNodes)
                        {
                            string name = node.Attributes["name"]?.Value;
                            int Count = int.Parse(node.Attributes["count"]?.Value);
                            int Dozirovka = int.Parse(node.Attributes["dozirovka"]?.Value);
                            int Price = int.Parse(node.Attributes["price"]?.Value);

                            doctor.AddZayvkaToDoctor(name, Count, Dozirovka, Price);
                            dataGridView1.Rows.Add(name, Count, Dozirovka, Price);
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
                MessageBox.Show("Файл Zayvkas.xml не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddZayvka(string a, int k, int b, int c)
        {
            dataGridView1.Rows.Add(a, k, b, c);
        }

        private void Modul_MainDoctor_FormClosing(object sender, EventArgs e) => Application.Exit();
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.Rows != null)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string name = row.Cells[0].Value.ToString();
                    int count = int.Parse(row.Cells[1].Value.ToString());
                    int dozirovka = int.Parse(row.Cells[2].Value.ToString());
                    int price = int.Parse(row.Cells[3].Value.ToString());
                    RemoveZayvkaFromXml(name, count, dozirovka, price);
                    doctor.RemoveSelectedRow();
                }
                MessageBox.Show("Заявка оформлена");
                LoadFromXml();
            }
            else
            {
                MessageBox.Show("Выберите строку с заполненными данными");
                return;
            }
                

        }

        private void button5_Click(object sender, EventArgs e)
        {

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string name = row.Cells[0].Value.ToString();
                    int count = int.Parse(row.Cells[1].Value.ToString());
                    int dozirovka = int.Parse(row.Cells[2].Value.ToString());
                    int price = int.Parse(row.Cells[3].Value.ToString());
                    RemoveZayvkaFromXml(name, count, dozirovka, price);
                    doctor.RemoveSelectedRow();
                }
  
        }
            

        private void label2_Click(object sender, EventArgs e)
        {

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
    }
}
