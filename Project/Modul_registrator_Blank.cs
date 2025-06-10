using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.IO;
using System.Text;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Reflection.Metadata;
using Document = DocumentFormat.OpenXml.Wordprocessing.Document;
using Body = DocumentFormat.OpenXml.Wordprocessing.Body;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class Modul_registrator_Blank : Form
    {

        private bool isCorrectBirthdate = false;
        private bool isCorrectPhone = false;
        private bool isCorrectPassport = false;
        private bool isCorrectCost = false;

        public Modul_registrator_Blank()
        {
            InitializeComponent();
        }

        private void Modul_registrator_Blank_FormClosing(object sender, FormClosingEventArgs e) => System.Windows.Forms.Application.Exit();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string phonePattern = @"^\+7\d{10}$";
            if (!Regex.IsMatch(textBox4.Text, phonePattern))
            {
                isCorrectPhone = false;
                return;
            }
            isCorrectPhone = true;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string passportPattern = @"^\d{6}$";

            if (!Regex.IsMatch(textBox2.Text, passportPattern))
            {
                isCorrectPassport = false;
                return;
            }
            isCorrectPassport = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox7.Text, out int number7))
            {

                isCorrectCost = false;
                return;
            }
            if (number7 < 0)
            {
                isCorrectCost = false;
                return;
            }
            isCorrectCost = true;

        }

        private void dateTimePicker1_TextChanged(object sender, EventArgs e)
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(textBox7.Text)
                || string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Не все поля заполнены");
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

            if (!isCorrectPassport)
            {
                MessageBox.Show("Неправильно введены серия и номер паспорта. Ожидается 6 цифр");
                return;
            }

            if (!isCorrectCost)
            {
                MessageBox.Show("Неверный формат стоимости");
                return;
            }

            if (!isCorrectComboBox2)
            {
                MessageBox.Show("Пожалуйста, выберите дату приема");
                return;
            }

            if (!isCorrectComboBox1)
            {
                MessageBox.Show("Пожалуйста, выберите способ оплаты");
                return;
            }

            string patientName = textBox1.Text;
            string patientBirthdate = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            string patientPassport = textBox2.Text;
            string patientAddress = textBox2.Text;
            string patientPhone = textBox4.Text;

            // Жестко задаем данные медицинского учреждения
            string hospitalName = "ООО 'МедЦентр'";
            string hospitalAddress = "г. Москва, ул. Лечебная, д. 2";
            string hospitalOgrn = "1234567890123";
            string hospitalPhone = "+74957777777";
            string licenseNumber = "Л041-01111-11/1111111";
            string licenseDate = "01.01.2024";


            string serviceName = textBox5.Text;
            string serviceDate = comboBox2.Text;
            string cost = textBox7.Text;
            string paymentTerms = comboBox1.Text;

            using (MemoryStream mem = new MemoryStream())
            {
                using (WordprocessingDocument document = WordprocessingDocument.Create(mem, WordprocessingDocumentType.Document, true))
                {
                    MainDocumentPart mainPart = document.AddMainDocumentPart();
                    mainPart.Document = new Document(new Body());

                    // Создание текста договора
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Договор на оказание платных медицинских услуг");
                    sb.AppendLine($"№ [номер договора] от {DateTime.Now:dd.MM.yyyy}");
                    sb.AppendLine();
                    sb.AppendLine("Заказчик (Пациент):");
                    sb.AppendLine($"ФИО: {patientName}");
                    sb.AppendLine($"Дата рождения: {patientBirthdate}");
                    sb.AppendLine($"Паспорт: {patientPassport}");
                    sb.AppendLine($"Адрес: {patientAddress}");
                    sb.AppendLine($"Телефон: {patientPhone}");
                    sb.AppendLine();
                    sb.AppendLine("Исполнитель (Медицинское учреждение):");
                    sb.AppendLine($"Наименование: {hospitalName}");
                    sb.AppendLine($"Адрес: {hospitalAddress}");
                    sb.AppendLine($"ОГРН: {hospitalOgrn}");
                    sb.AppendLine($"Телефон: {hospitalPhone}");
                    sb.AppendLine($"Лицензия: № {licenseNumber} от {licenseDate}");
                    sb.AppendLine();
                    sb.AppendLine("Предмет Договора:");
                    sb.AppendLine($"Оказание медицинских услуг по {serviceName}");
                    sb.AppendLine();
                    sb.AppendLine("Условия Оказания Медицинских Услуг:");
                    sb.AppendLine($"Срок оказания услуг: {serviceDate}");
                    sb.AppendLine("Пациент обязуется предоставлять достоверные сведения о своем здоровье.");
                    sb.AppendLine("Медицинское учреждение обязуется оказать услуги качественно и в срок.");
                    sb.AppendLine();
                    sb.AppendLine("Стоимость и Порядок Оплаты:");
                    sb.AppendLine($"Общая стоимость услуг: {cost} руб.");
                    sb.AppendLine($"Порядок оплаты: {paymentTerms}");
                    sb.AppendLine();
                    sb.AppendLine("Ответственность Сторон:");
                    sb.AppendLine("Стороны несут ответственность за неисполнение или ненадлежащее исполнение обязательств по настоящему договору в соответствии с действующим законодательством.");
                    sb.AppendLine();
                    sb.AppendLine("Заключительные Положения:");
                    sb.AppendLine("Договор вступает в силу с момента его подписания.");
                    sb.AppendLine("Договор может быть изменен или расторгнут по взаимному соглашению сторон или в порядке, предусмотренном законодательством.");
                    sb.AppendLine();
                    sb.AppendLine("Реквизиты и Подписи Сторон:");
                    sb.AppendLine("Заказчик (Пациент): ________________________ (подпись)");
                    sb.AppendLine("Исполнитель (Медицинское учреждение):  ________________________ (подпись, печать)");

                    string documentText = sb.ToString();
                    string[] paragraphs = documentText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
                    // Форматируем текст
                    foreach (string paragraphText in paragraphs)
                    {
                        Paragraph paragraph = new Paragraph();
                        Run run = new Run();
                        Text text = new Text(paragraphText);
                        run.Append(text);

                        // Форматирование заголовка
                        if (paragraphText.Contains("Договор на оказание платных медицинских услуг"))
                        {
                            RunProperties runProperties = new RunProperties();
                            runProperties.Append(new Bold());
                            runProperties.Append(new FontSize { Val = "28" });
                            run.PrependChild(runProperties);
                            ParagraphProperties paragraphProperties = new ParagraphProperties();
                            paragraphProperties.Append(new Justification() { Val = JustificationValues.Center });
                            paragraph.Append(paragraphProperties);
                        }
                        // Форматирование заголовка секции
                        else if (paragraphText.Contains("Заказчик (Пациент):") || paragraphText.Contains("Исполнитель (Медицинское учреждение):") || paragraphText.Contains("Предмет Договора:") || paragraphText.Contains("Условия Оказания Медицинских Услуг:") || paragraphText.Contains("Стоимость и Порядок Оплаты:") || paragraphText.Contains("Ответственность Сторон:") || paragraphText.Contains("Заключительные Положения:") || paragraphText.Contains("Реквизиты и Подписи Сторон:"))
                        {
                            RunProperties runProperties = new RunProperties();
                            runProperties.Append(new Bold());
                            runProperties.Append(new FontSize { Val = "20" });
                            run.PrependChild(runProperties);
                            ParagraphProperties paragraphProperties = new ParagraphProperties();
                            paragraphProperties.Append(new SpacingBetweenLines() { Line = "200", LineRule = LineSpacingRuleValues.Auto });
                            paragraph.Append(paragraphProperties);
                        }
                        // Отступы
                        else if (paragraphText.Contains("ФИО:") || paragraphText.Contains("Дата рождения:") || paragraphText.Contains("Паспорт:") || paragraphText.Contains("Адрес:") || paragraphText.Contains("Телефон:")
                        || paragraphText.Contains("Наименование:") || paragraphText.Contains("Адрес:") || paragraphText.Contains("ОГРН:") || paragraphText.Contains("Телефон:") || paragraphText.Contains("Лицензия:")
                        || paragraphText.Contains("Срок оказания услуг:") || paragraphText.Contains("Пациент обязуется предоставлять достоверные сведения о своем здоровье.") || paragraphText.Contains("Медицинское учреждение обязуется оказать услуги качественно и в срок.")
                         || paragraphText.Contains("Общая стоимость услуг:") || paragraphText.Contains("Порядок оплаты:")
                          || paragraphText.Contains("Договор вступает в силу с момента его подписания.") || paragraphText.Contains("Договор может быть изменен или расторгнут по взаимному соглашению сторон или в порядке, предусмотренном законодательством."))
                        {
                            ParagraphProperties paragraphProperties = new ParagraphProperties();
                            paragraphProperties.Append(new Indentation { Left = "200" });
                            paragraph.Append(paragraphProperties);
                        }


                        paragraph.Append(run);
                        mainPart.Document.Body.Append(paragraph);
                    }
                    document.Clone();
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Word Document (*.docx)|*.docx";
                saveFileDialog.Title = "Сохранить договор";
                saveFileDialog.FileName = "Contract.docx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, mem.ToArray());
                }


            }
        }
        private static string Name;
        public string SetName
        {
            get { return Name; }
            set { Name = value; }
        }
        private void Modul_registrator_Blank_Load(object sender, EventArgs e) => label2.Text = Name;
        private Modul_Registrator_Zapis zapis;
        private Authorisation authorisation;
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (authorisation != null)
            {
                authorisation.Show();
            }
            else
            {
                authorisation = new Authorisation();
                authorisation.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (zapis != null)
            {
                zapis.Show();
            }
            else
            {
                zapis = new Modul_Registrator_Zapis();
                zapis.SetName = Name;
                zapis.Show();
            }
        }

        private bool isCorrectComboBox2 = false;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null || string.IsNullOrEmpty(comboBox2.SelectedItem.ToString()))
            {
                isCorrectComboBox2 = false;
                return;
            }
            isCorrectComboBox2 = true;
        }

        private bool isCorrectComboBox1 = false;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
            {
                isCorrectComboBox1 = false;
                return;
            }
            isCorrectComboBox1 = true;
        }
    }
}
