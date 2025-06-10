using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Project.Classes;

namespace Project
{
    public partial class Modul_Pharmaceutist_Zayvka : Form
    {
        public Modul_Pharmaceutist_Zayvka()
        {
            InitializeComponent();
            pharm = new Role_Pharmaceutist();
        }
        private Modul_Pharmaceutist_Medicines medicines;
        private Role_Pharmaceutist pharm;

        private static string Name;
        public string SetName
        {
            get { return Name; }
            set { Name = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (medicines != null)
            {
                medicines.Show();
            }
            else
            {
                medicines = new Modul_Pharmaceutist_Medicines();
                medicines.SetName = Name;
                medicines.Show();
            }
        }
        private void Modul_Pharmaceutist_Zayvka_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
        private void Modul_Pharmaceutist_Zayvka_Load(object sender, EventArgs e) => label2.Text = Name;
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
            string name = textBox1.Text;
            int count = Convert.ToInt32(numericUpDown1.Value);
            int dozirovka = Convert.ToInt32(textBox4.Text);
            int price = Convert.ToInt32(textBox2.Text);
            if (name == null || count == 0 || dozirovka == null || price == null)
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            MessageBox.Show("Заявка отправлена");
            ExportToXml(name, count, dozirovka, price);
            textBox1.Text = ""; textBox2.Text = ""; textBox4.Text = ""; numericUpDown1.Value = 1;



        }
        private void ExportToXml(string name, int count, int dozirovka, int price)
        {
            string filePath = "Zayvkas.xml";
            XmlDocument doc = new XmlDocument();
            if (File.Exists(filePath))
            {
                doc.Load(filePath);
            }
            else
            {
                XmlElement root = doc.CreateElement("Zayvkas");
                doc.AppendChild(root);
            }

            XmlElement zayvkasElement = doc.DocumentElement;


            XmlElement zayvkaElement = doc.CreateElement("zayvka");


            XmlAttribute nameAttribute = doc.CreateAttribute("name");
            nameAttribute.Value = name;
            zayvkaElement.Attributes.Append(nameAttribute);

            XmlAttribute countAttribute = doc.CreateAttribute("count");
            countAttribute.Value = count.ToString();
            zayvkaElement.Attributes.Append(countAttribute);

            XmlAttribute dozirovkaAttribute = doc.CreateAttribute("dozirovka");
            dozirovkaAttribute.Value = dozirovka.ToString();
            zayvkaElement.Attributes.Append(dozirovkaAttribute);

            XmlAttribute priceAttribute = doc.CreateAttribute("price");
            priceAttribute.Value = price.ToString();
            zayvkaElement.Attributes.Append(priceAttribute);

            zayvkasElement.AppendChild(zayvkaElement);
            doc.Save(filePath);
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

        private bool isInt1 = false, isInt2 = false;

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox4.Text, out int number4))
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
                isInt1 = false;
                return;
            }
            isInt1 = true;

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
