using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Classes
{
    public class Role_Pharmaceutist
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public int Dozirovka { get; set; }
        public int Price { get; set; }
        public Role_Pharmaceutist(string name, int count, int dozirovka, int price)
        {
            Name = name;
            Count = count;
            Dozirovka = dozirovka;
            Price = price;
        }

        public Role_Pharmaceutist()
        {

        }

        private DataGridView _dataGridView;
        public Role_Pharmaceutist(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
        }

        public void AddMedicine(string Name, int Count, int Dozirovka, int Price) => _dataGridView.Rows.Add(Name, Count, Dozirovka, Price);
        public void RemoveSelectedMedicines()
        {
            if (_dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in _dataGridView.SelectedRows)
                {
                    _dataGridView.Rows.Remove(row);
                }
            }
        }
        public void AddDefaultMedicines()
        {
            _dataGridView.Rows.Add("Парацетамол", 90, 500, 324);
            _dataGridView.Rows.Add("Ибупрофен", 90, 200, 220);
            _dataGridView.Rows.Add("Аспирин", 100, 500, 100);
            _dataGridView.Rows.Add("Амоксициллин", 50, 500, 324);
            _dataGridView.Rows.Add("Лоратадин", 15, 10, 110);
        }
        public void CreateZayvka(string name, int count, int dozirovka, int price)
        {
            if (!string.IsNullOrEmpty(name) && count > 0 && dozirovka > 0 && price > 0)
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
