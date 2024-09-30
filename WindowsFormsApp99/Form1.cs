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
    public partial class Form1 : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DataBase10.mdb";
        private OleDbConnection Connection;
        public Form1()
        {
            InitializeComponent();
            Connection = new OleDbConnection(connectString);
            Connection.Open();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            this.экзаменыTableAdapter1.Fill(this.dataBase10DataSet1.Экзамены);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.currentRow = null;
            f.lastRowID = dataGridView1.RowCount;
            f.Text = "Добавление";
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.currentRow = экзаменыBindingSource.Current as DataRowView;
            int cellValue = 0;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                cellValue = Convert.ToInt32(selectedRow.Cells[0].Value);
            }
            f.currentRowID = cellValue;
            f.lastRowID = dataGridView1.RowCount;
            f.Text = "Редактирование";
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int kod = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string query = "DELETE FROM Экзамены WHERE Код = " + kod;
                OleDbCommand command = new OleDbCommand(query, Connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Элемент удален!");
            }
            this.экзаменыTableAdapter1.Fill(this.dataBase10DataSet1.Экзамены);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.экзаменыTableAdapter1.Fill(this.dataBase10DataSet1.Экзамены);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Owner = this;
            f.Text = "Таблицы";
            f.Show();
        }
    }
}
