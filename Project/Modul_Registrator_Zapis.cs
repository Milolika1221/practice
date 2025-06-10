using DocumentFormat.OpenXml.Bibliography;
using Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Project
{
    public partial class Modul_Registrator_Zapis : Form
    {
        private Role_Registrator registrator;
        private Modul_registrator_Blank blank;


        public Modul_Registrator_Zapis()
        {
            InitializeComponent();
            registrator = new Role_Registrator(dataGridView1, comboBox1, textBox4, comboBox2, comboBox4);
        }

        public DataGridView GetDataGridView() => dataGridView1;

        Authorisation authorFrm;
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            authorFrm = new Authorisation();
            authorFrm.Show();
        }
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
                            dataGridView1.Rows.Add(name, date, numberPhone, SpecialDoctor, Doctor, DataTime, Allergia, Diseases, Type);
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
                MessageBox.Show("Файл Zapisesr.xml не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static string Name;
        public string SetName
        {
            get { return Name; }
            set { Name = value; }
        }

        private void Modul_Registrator_Load(object sender, EventArgs e)
        {
            label2.Text = Name;
            LoadFromXml();
        }

        private void Modul_Registrator_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private Modul_MainDoctor_Zapis zapis;
        private Role_MainDoctor doctor;
        private void button3_Click(object sender, EventArgs e)
        {
            if (
                 string.IsNullOrWhiteSpace(textBox1.Text) ||
                 string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) ||
                 string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(comboBox4.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (!isTrue)
            {
                MessageBox.Show("Выберите тип приема");
                return;
            }
            if (!isCorrectBirthdate)
            {
                MessageBox.Show("Неверный формат даты рождения");
                return;
            }

            if (!isCorrectPhone)
            {
                MessageBox.Show("Неправильно введен номер телефона. Ожидался формат: +79874567667");
                return;
            }

            registrator.AddPattient(textBox1.Text, dateTimePicker1.Text, textBox3.Text, comboBox1.Text, textBox4.Text, comboBox4.Text, textBox5.Text, textBox6.Text, comboBox2.Text);
            ExportToXml(textBox1.Text, dateTimePicker1.Text, textBox3.Text, comboBox1.Text, textBox4.Text, comboBox4.Text, textBox5.Text, textBox6.Text, comboBox2.Text);
            textBox1.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); textBox6.Clear();

        }

        private void ExportToXml(string name, string date, string NumberPhone, string SpecialDoctor, string Doctor, string DataTime, string Allergia, string Diseases, string Type)
        {
            string filePath = "Zapises.xml";
            XmlDocument doc = new XmlDocument();
            if (File.Exists(filePath))
            {
                doc.Load(filePath);
            }
            else
            {
                XmlElement root = doc.CreateElement("Zapises");
                doc.AppendChild(root);
            }

            XmlElement zapisElement = doc.DocumentElement;


            XmlElement zapisElementElement = doc.CreateElement("zapis");


            XmlAttribute nameAttribute = doc.CreateAttribute("name");
            nameAttribute.Value = name;
            zapisElementElement.Attributes.Append(nameAttribute);

            XmlAttribute dateAttribute = doc.CreateAttribute("date");
            dateAttribute.Value = date;
            zapisElementElement.Attributes.Append(dateAttribute);

            XmlAttribute phoneAttribute = doc.CreateAttribute("NumberPhone");
            phoneAttribute.Value = NumberPhone;
            zapisElementElement.Attributes.Append(phoneAttribute);

            XmlAttribute spDoctorAttribute = doc.CreateAttribute("SpecialDoctor");
            spDoctorAttribute.Value = SpecialDoctor;
            zapisElementElement.Attributes.Append(spDoctorAttribute);

            XmlAttribute DoctorAttribute = doc.CreateAttribute("Doctor");
            DoctorAttribute.Value = Doctor;
            zapisElementElement.Attributes.Append(DoctorAttribute);

            XmlAttribute DataTimeAttribute = doc.CreateAttribute("DataAndTime");
            DataTimeAttribute.Value = DataTime;
            zapisElementElement.Attributes.Append(DataTimeAttribute);

            XmlAttribute AllergiaAttribute = doc.CreateAttribute("Allergia");
            AllergiaAttribute.Value = Allergia;
            zapisElementElement.Attributes.Append(AllergiaAttribute);

            XmlAttribute DiseasesAttribute = doc.CreateAttribute("Diseases");
            DiseasesAttribute.Value = Diseases;
            zapisElementElement.Attributes.Append(DiseasesAttribute);

            XmlAttribute TypeAttribute = doc.CreateAttribute("Type");
            TypeAttribute.Value = Type;
            zapisElementElement.Attributes.Append(spDoctorAttribute);

            zapisElement.AppendChild(zapisElementElement);
            doc.Save(filePath);
        }
        private bool isCorrectPhone = false;
        private void button5_Click(object sender, EventArgs e)
        {

            registrator.RemoveSelected();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string phonePattern = @"^\+7\d{10}$";
            if (!Regex.IsMatch(textBox4.Text, phonePattern))
            {
                isCorrectPhone = false;
                return;
            }
            isCorrectPhone = true;
        }

        private void dateTimePicker1_TextChanged(object sender, EventArgs e) { }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (blank != null)
            {
                blank.Show();
            }
            else
            {
                blank = new Modul_registrator_Blank();
                blank.SetName = Name;
                blank.Show();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool isCorrectBirthdate = false;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(dateTimePicker1.Text, out DateTime selectedDate))
            {
                isCorrectBirthdate = false;
                return;
            }
            int yearBorn = Convert.ToInt32(dateTimePicker1.Value.ToString("yyyy"));
            if (yearBorn >= 2024)
            {
                isCorrectBirthdate = false;
                return;
            }

            isCorrectBirthdate = true;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool isTrue = false;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string selectedValue = comboBox2.SelectedItem.ToString();
                if (selectedValue == "Первичный" || selectedValue == "Повторный")
                {

                    isTrue = true;
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
