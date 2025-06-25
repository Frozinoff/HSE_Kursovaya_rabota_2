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
    public partial class Form6 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= DB.mdb";
        private OleDbConnection myConnection;
        public Form6()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.dBDataSet.Группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Обучаемые". При необходимости она может быть перемещена или удалена.
            this.обучаемыеTableAdapter.Fill(this.dBDataSet.Обучаемые);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Owner = this;
            f7.Show();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.обучаемыеTableAdapter.Fill(this.dBDataSet.Обучаемые);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Обучаемые WHERE Код = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные об обучаемом удалены!");
            this.обучаемыеTableAdapter.Fill(this.dBDataSet.Обучаемые);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string FIO = textBox3.Text;
            string query = "UPDATE Обучаемые SET [ФИО_обучаемого] = '" + FIO + "' WHERE Код = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о преподователе изменены!");
            this.обучаемыеTableAdapter.Fill(this.dBDataSet.Обучаемые);
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string FIO = textBox4.Text;
            string query = "UPDATE Обучаемые SET Предмет = '" + FIO + "' WHERE Код = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о преподователе изменены!");
            this.обучаемыеTableAdapter.Fill(this.dBDataSet.Обучаемые);
            textBox2.Text = "";
            textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            int FIO = Convert.ToInt32(textBox5.Text);
            string query = "UPDATE Обучаемые SET Стоимость = " + FIO + " WHERE Код = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о преподователе изменены!");
            this.обучаемыеTableAdapter.Fill(this.dBDataSet.Обучаемые);
            textBox2.Text = "";
            textBox5.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            int FIO = Convert.ToInt32(listBox1.Text);
            string query = "UPDATE Обучаемые SET [Номер_группы] = " + FIO + " WHERE Код = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о преподователе изменены!");
            this.обучаемыеTableAdapter.Fill(this.dBDataSet.Обучаемые);
            textBox2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string FIO = textBox7.Text;
            string query = "UPDATE Обучаемые SET Адресс = '" + FIO + "' WHERE Код = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о преподователе изменены!");
            this.обучаемыеTableAdapter.Fill(this.dBDataSet.Обучаемые);
            textBox2.Text = "";
            textBox7.Text = "";
        }
    }
}
