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
    public partial class Form3 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= DB.mdb";
        private OleDbConnection myConnection;
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            int chislo = Convert.ToInt32(textBox2.Text);
            string query = "INSERT INTO Группы VALUES (" + kod + "," + chislo + ")";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Группа добавлена!");
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
