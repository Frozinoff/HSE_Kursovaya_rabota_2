using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KorovinDB
{
    public partial class Form4 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= DB.mdb";
        private OleDbConnection myConnection;
        public Form4()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Преподаватели". При необходимости она может быть перемещена или удалена.
            this.преподавателиTableAdapter.Fill(this.dBDataSet.Преподаватели);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kod = textBox1.Text;
            string query = "DELETE FROM Преподаватели WHERE [ФИО_преподователя] = ('" + kod + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о преподователе удалены!");
            this.преподавателиTableAdapter.Fill(this.dBDataSet.Преподаватели);
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string kod = textBox2.Text;
            string adress = textBox3.Text;
            string query = "UPDATE Преподаватели SET Предмет = '" + adress + "' WHERE [ФИО_преподователя] ='" + kod + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о преподователе изменены!");
            this.преподавателиTableAdapter.Fill(this.dBDataSet.Преподаватели);
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string kod = textBox2.Text;
            int adress = Convert.ToInt32(textBox4.Text);
            string query = "UPDATE Преподаватели SET Телефон = " + adress + " WHERE [ФИО_преподователя] ='" + kod + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о преподователе изменены!");
            this.преподавателиTableAdapter.Fill(this.dBDataSet.Преподаватели);
            textBox2.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kod = textBox2.Text;
            string adress = textBox5.Text;
            string query = "UPDATE Преподаватели SET Адресс = '" + adress + "' WHERE [ФИО_преподователя] ='" + kod + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о преподователе изменены!");
            this.преподавателиTableAdapter.Fill(this.dBDataSet.Преподаватели);
            textBox2.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.преподавателиTableAdapter.Fill(this.dBDataSet.Преподаватели);
        }
    }
}
