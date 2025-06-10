using System;
using System.Xml;
using System.Xml.Linq;
using Project.Classes;

namespace Project
{
    public partial class Authorisation : Form
    {
        public Authorisation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool isTrue = false;
        Modul_Pharmaceutist_Medicines medicines;
        Modul_ManagerFood manager;
        Modul_Registrator_Zapis registrator;
        Modul_MainDoctor_Zayvka doctor;
        private void button1_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                User user = User.LoadFromXml(login, password);
                if (user != null)
                {
                    this.Hide();
                    if (user.Role == "Фармацевт")
                    {
                        if (medicines != null)
                        {
                            medicines.Show();
                        }
                        else
                        {
                            medicines = new Modul_Pharmaceutist_Medicines();
                            medicines.SetName = user.Name;
                            medicines.Show();
                        }
                    }
                    else if (user.Role == "ЗаведПищ")
                    {
                        if (manager != null)
                        {
                            manager.Show();
                        }
                        else
                        {
                            manager = new Modul_ManagerFood();
                            manager.SetName = user.Name;
                            manager.Show();
                        }
                    }
                    else if (user.Role == "Регистратор")
                    {
                        if (registrator != null)
                        {
                            registrator.Show();
                        }
                        else
                        {
                            registrator = new Modul_Registrator_Zapis();
                            registrator.SetName = user.Name;
                            registrator.Show();
                        }
                    }
                    else if (user.Role == "Главный врач")
                    {
                        if (doctor != null)
                        {
                            doctor.Show();
                        }
                        else
                        {
                            doctor = new Modul_MainDoctor_Zayvka();
                            doctor.SetName = user.Name;
                            doctor.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }

            }
            else MessageBox.Show("Не все заполнены поля");
        }

        private void Authorisation_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}
