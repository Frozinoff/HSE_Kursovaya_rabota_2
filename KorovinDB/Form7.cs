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
    public partial class Form7 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= DB.mdb";
        private OleDbConnection myConnection;
        public Form7()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string FIO = textBox2.Text;
            string predmet = textBox3.Text;
            int money = Convert.ToInt32(textBox4.Text);
            int nomer = Convert.ToInt32(listBox1.Text);
            string adress = textBox6.Text;
            string query = "INSERT INTO Обучаемые VALUES (" + kod + ",'" + FIO + "','" + predmet + "'," + money + "," + nomer + ", '" + adress + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("преподователь добавлен!");
            Close();
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            myConnection.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.dBDataSet.Группы);

        }
    }
}
