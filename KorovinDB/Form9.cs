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
    public partial class Form9 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = DB.mdb";
        private OleDbConnection myConnection;
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string znach = textBox1.Text;
            string query = "Select * FROM Преподаватели WHERE [ФИО_преподователя] LIKE '%" + znach + "%'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }
    }
}
