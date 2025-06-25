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
    public partial class Form5 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= DB.mdb";
        private OleDbConnection myConnection;
        public Form5()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kod = textBox1.Text;
            string predmet = textBox2.Text;
            int nomer = Convert.ToInt32(textBox3.Text);
            string adress = textBox4.Text;
            string query = "INSERT INTO Преподаватели VALUES ('" + kod + "','" + predmet + "'," + nomer + ",'" + adress + "')";
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
    }
}
