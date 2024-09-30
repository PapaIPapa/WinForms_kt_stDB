using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public DataRowView currentRow;
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DataBase10.mdb";
        private OleDbConnection Connection;
        public int lastRowID;
        public int currentRowID;
        public Form2()
        {
            InitializeComponent();
            Connection = new OleDbConnection(connectString);
            Connection.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (currentRow != null)
            {
                label12.Text = currentRowID.ToString();
                textBox1.Text = currentRow.Row["Фио абитуриента"].ToString();
                textBox2.Text = currentRow.Row["Адрес"].ToString();
                textBox3.Text = currentRow.Row["Год рождения абитуриента"].ToString();
                textBox4.Text = currentRow.Row["Паспорт абитуриента"].ToString();
                textBox5.Text = currentRow.Row["Фио экзаменатора"].ToString();
                textBox6.Text = currentRow.Row["Размер оплаты"].ToString();
                textBox7.Text = currentRow.Row["Название экзамена"].ToString();
                textBox8.Text = currentRow.Row["Оценка"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(currentRow.Row["Дата сдачи экзамена"]);
                label13.Text = currentRow.Row["Оплата за прием"].ToString();

                button1.Text = "Редактировать";
            }
            else
            {
                label12.Text = (lastRowID).ToString();
                button1.Text = "Добавить";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Ты не заполнил все поля");
                return;
            }
            int kod = Convert.ToInt32(label12.Text);
            string fio_ab = textBox1.Text;
            string adress = textBox2.Text;
            string god = textBox3.Text;
            string passport = textBox4.Text;
            string fio_ex = textBox5.Text;
            string oplata = textBox6.Text;
            string date = dateTimePicker1.Value.ToString();
            string ex = textBox7.Text;
            string mark = textBox8.Text;
            double num = Convert.ToDouble(oplata);
            double num2 = num - (num / 100 * 13) - ((num - (num / 100 * 13)) / 100 * 20);
            string oplata_pr = Convert.ToString(num2);
            string query = null;
            if (currentRow == null)
            {
                query = "INSERT INTO Экзамены (Код, [Фио абитуриента], [Адрес], [Год рождения абитуриента], [Паспорт абитуриента], [Фио экзаменатора], [Размер оплаты], [Дата сдачи экзамена], [Название экзамена], [Оценка], [Оплата за прием]) " +
                    "VALUES (" + kod + ", '" + fio_ab + "', '" + adress + "', " + god + ",  '" + passport + "',  '" + fio_ex + "'," +
                     "  " + oplata + ",  '" + date + "',  '" + ex + "',  '" + mark + "',  " + oplata_pr + ")";
            }
            else
            {
                query = $"UPDATE Экзамены SET [Фио абитуриента] = '{fio_ab}',  [Адрес] = '{adress}', " +
                    $"[Год рождения абитуриента] = {god}, [Паспорт абитуриента] = '{passport}', " +
                    $"[Фио экзаменатора] = '{fio_ex}', [Размер оплаты] = {oplata},  " +
                    $"[Дата сдачи экзамена] = '{date}', [Название экзамена] = '{ex}', [Оценка] = '{mark}', [Оплата за прием] = {oplata_pr} WHERE Код = {kod}";
            }
            Console.WriteLine(query);
            OleDbCommand command = new OleDbCommand(query, Connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Строка добавлена!");
            Close();
        }
    }
}
