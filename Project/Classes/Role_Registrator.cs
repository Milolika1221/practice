using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Role_Registrator
    {
        public string User { get; set; }
        public string Data { get; set; }
        public string Phone { get; set; }
        public string SpecialDoctor { get; set; }
        public string Doctor { get; set; }
        public string Allergia {  get; set; }
        public string Diseases { get; set; }
        public string Type { get; set; }
        public string DataPriema {  get; set; }

        public Role_Registrator(string user, string data, string phone, string special_doctor, string doctor, string data_priema, string allergia, string diseases, string type)
        {
            User = user;
            Data = data;
            Phone = phone;
            SpecialDoctor = special_doctor;
            Doctor = doctor;
            DataPriema = data_priema;
            Allergia = allergia;
            Diseases = diseases;
            Type = type;
        }
        public Role_Registrator()
        {
        }
        private DataGridView _dataGridView;

        public void AddPattient(string User, string Data, string Phone, string SpecialDoctor, string Doctor, string DataPriema, string Allergia, string Diseases, string Type) => _dataGridView.Rows.Add(User, Data, Phone, SpecialDoctor, Doctor, DataPriema, Allergia, Diseases, Type);
        public void RemoveSelected()
        {
            if (_dataGridView.SelectedRows.Count > 0 && _dataGridView.SelectedRows != null)
            {
                foreach (DataGridViewRow row in _dataGridView.SelectedRows)
                {
                    _dataGridView.Rows.Remove(row);
                }
            }
        }
        private ComboBox _comboBox1, _comboBox2, _comboBox3;
        private TextBox _textBox1;

        public Role_Registrator(DataGridView dataGridView, ComboBox comboBox1, TextBox textBox1, ComboBox comboBox2, ComboBox comboBox3)
        {
            _dataGridView = dataGridView;
            _comboBox1 = comboBox1;
            _comboBox2 = comboBox2;
            _comboBox3 = comboBox3;
            _textBox1 = textBox1;

            _comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            _textBox1.TextChanged += TextBox1_SelectedTextChanged;
            _comboBox3.TextChanged += ComboBox3_TextChanged;
        }


        private void ComboBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_comboBox3.Text))
            {
                MessageBox.Show("Выберите дату и время приема");
                return;
            }
                
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) => UpdateText();
        private void TextBox1_SelectedTextChanged(object sender, EventArgs e) => UpdateText();

        public void UpdateText()
        {
            if (_comboBox1.SelectedItem != null)
            {
                string selectedValue = _comboBox1.SelectedItem.ToString();
                if (selectedValue == "Главный врач")
                    _textBox1.Text = "Василий Чернов";
                else if (selectedValue == "Терапевт")
                    _textBox1.Text = "Кожников Михаил";
                else if (selectedValue == "Педиатр")
                    _textBox1.Text = "Василенко Мария";
            }

            if (_textBox1.Text != null)
            {
                string text = _textBox1.Text;
                if (text == "Василий Чернов")
                {
                    _comboBox3.Items.Add("20 января 14:00");
                    _comboBox3.Items.Add("19 января 12:00");
                    _comboBox3.Items.Add("22 января 18:00");
                }
                else if (text == "Кожников Михаил")
                {
                    _comboBox3.Items.Add("1 февраля 10:00");
                    _comboBox3.Items.Add("10 февраля 12:00");
                    _comboBox3.Items.Add("11 февраля 18:00");
                }
                else if (text == "Василенко Мария")
                {
                    _comboBox3.Items.Add("10 января 10:00");
                    _comboBox3.Items.Add("11 января 12:00");
                    _comboBox3.Items.Add("12 января 18:00");
                }
                else
                {
                    MessageBox.Show("Выберите специализацию врача");
                    return;
                    _comboBox3.Items.Clear();
                }
            }

        }
    }
    
}
