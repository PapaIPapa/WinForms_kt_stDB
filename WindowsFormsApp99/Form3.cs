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
    public partial class Form3 : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DataBase10.mdb";
        private OleDbConnection Connection;
        public Form3()
        {
            InitializeComponent();
            Connection = new OleDbConnection(connectString);
            Connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"SELECT [Код], [Фио абитуриента], [Адрес], [Год рождения абитуриента], [Паспорт абитуриента] FROM Экзамены ";
            Console.WriteLine(query);
            OleDbDataAdapter command = new OleDbDataAdapter(query, Connection);
            DataTable Table = new DataTable();
            command.Fill(Table);
            dataGridView1.DataSource = Table;
            Connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = $"SELECT [Код], [Фио экзаменатора], [Размер оплаты], [Оплата за прием] FROM Экзамены ";
            Console.WriteLine(query);
            OleDbDataAdapter command = new OleDbDataAdapter(query, Connection);
            DataTable Table = new DataTable();
            command.Fill(Table);
            dataGridView1.DataSource = Table;
            Connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = $"SELECT [Код], [Дата сдачи экзамена], [Название экзамена], [Оценка] FROM Экзамены ";
            Console.WriteLine(query);
            OleDbDataAdapter command = new OleDbDataAdapter(query, Connection);
            DataTable Table = new DataTable();
            command.Fill(Table);
            dataGridView1.DataSource = Table;
            Connection.Close();
        }
    }
}
