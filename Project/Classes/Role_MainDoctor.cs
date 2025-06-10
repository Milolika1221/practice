using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Classes
{
    public class Role_MainDoctor
    {
        private DataGridView _dataGridView;

        public string User { get; set; }
        public string Data { get; set; }
        public string Phone { get; set; }
        public string SpecialDoctor { get; set; }
        public string Doctor { get; set; }
        public string Allergia { get; set; }
        public string Diseases { get; set; }
        public string Type { get; set; }
        public string DataPriema { get; set; }

        public Role_MainDoctor(string user, string data, string phone, string special_doctor, string doctor, string data_priema, string allergia, string diseases, string type)
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
        public void AddDefaultPatient()
        {
            _dataGridView.Rows.Add("Виктор Алексеевич Фрейзер", "05.10.2002", "+79130787887", "Главный врач", "Екатерина Соколова", "31.12.2024 12:00", "", "", "Первичный");
        }

        public void AddDefaultShedule()
        {
            _dataGridView.Rows.Add("Василий Чернов", "Главный врач", "20 января", "14:00");
            _dataGridView.Rows.Add("Василий Чернов", "Главный врач", "19 января", "12:00");
            _dataGridView.Rows.Add("Василий Чернов", "Главный врач", "22 января", "18:00");
            _dataGridView.Rows.Add("Кожников Михаил", "Терапевт", "1 февраля", "10:00");
            _dataGridView.Rows.Add("Кожников Михаил", "Терапевт", "10 февраля", "12:00");
            _dataGridView.Rows.Add("Кожников Михаил", "Терапевт", "11 февраля", "18:00");
            _dataGridView.Rows.Add("Василенко Мария", "Педиатр", "10 января", "10:00");
            _dataGridView.Rows.Add("Василенко Мария", "Педиатр", "11 января", "12:00");
            _dataGridView.Rows.Add("Василенко Мария", "Педиатр", "12 января", "18:00");
        }

        public void AddZayvkaToDoctor(string Name, int Count, int Dozirovka, int Price) => _dataGridView.Rows.Add(Name, Count, Dozirovka, Price);

        public void AddZapisToDoctor(string user, string data, string phone, string special_doctor, string doctor, string data_priema, string allergia, string diseases, string type) => _dataGridView.Rows.Add(User, Data, Phone, SpecialDoctor, Doctor, DataPriema, Allergia, Diseases, Type);

        public Role_MainDoctor(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
        }
        public void RemoveSelectedRow()
        {
            if (_dataGridView.SelectedRows.Count > 0 && _dataGridView.SelectedRows != null)
            {
                foreach (DataGridViewRow row in _dataGridView.SelectedRows)
                {
                    _dataGridView.Rows.Remove(row);
                }
            }
        }
    }
}
