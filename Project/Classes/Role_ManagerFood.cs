using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Project.Classes
{
    public class Role_ManagerFood
    {
        public string Name { get; set; }
        public string Data { get; set; }
        public string Srok { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public Role_ManagerFood(string name, string data, string srok, int count, int price)
        {
            Name = name;
            Data = data;
            Srok = srok;
            Count = count;
            Price = price;
        }

        public Role_ManagerFood()
        {

        }

        private DataGridView _dataGridView;
        public Role_ManagerFood(DataGridView dataGridView) 
        { 
            _dataGridView = dataGridView;
        }
        public void AddFood(string Name, int Count, string Data, string Srok, int Price) => _dataGridView.Rows.Add(Name, Count, Data, Srok, Price);
        public void RemoveSelectedFood()
        {
            if (_dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in _dataGridView.SelectedRows)
                {
                    _dataGridView.Rows.Remove(row);
                }
            }
        }
        public void AddDefaultFood()
        {
            _dataGridView.Rows.Add("Хлеб “Бородинский”", 90, "15.12.2024", "25.12.2024", 51);
            _dataGridView.Rows.Add("Яйца куриные", 45, "21.12.2024", "05.01.2025", 110);
            _dataGridView.Rows.Add("Яблоки “Голден”", 30, "19.12.2024", "10.01.2025", 100);
            _dataGridView.Rows.Add("Сахар-песок", 100, "10.12.2024", ".03.03.2025", 90);
            _dataGridView.Rows.Add("Чай “Гринфилд”", 100, "15.12.2024", "25.04.2025", 220);
        }
        public void CreateOrder(string name, string data, string srok, int count, int price)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(data) && !string.IsNullOrEmpty(srok) && count > 0 && price > 0)
            {
                MessageBox.Show("Заявка оформлена");
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }
    }
}
