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
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = DB.mdb";
        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Преподаватели". При необходимости она может быть перемещена или удалена.
            this.преподавателиTableAdapter.Fill(this.dBDataSet.Преподаватели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Обучаемые". При необходимости она может быть перемещена или удалена.
            this.обучаемыеTableAdapter.Fill(this.dBDataSet.Обучаемые);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.dBDataSet.Группы);

        }

        private void поНомеруГруппыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Owner = this;
            f14.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите выйти?";
            String caption = "Выход";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Owner = this;
            f4.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Owner = this;
            f6.Show();
            Hide();
        }

        private void номерГруппыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Owner = this;
            f8.Show();
        }

        private void фИОПреподователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Owner = this;
            f9.Show();
        }

        private void предметToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Owner = this;
            f10.Show();
        }

        private void телефонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Owner = this;
            f11.Show();
        }

        private void адрессToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Owner = this;
            f12.Show();
        }

        private void поФИООбучаемогоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Owner = this;
            f13.Show();
        }

        private void адрессToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Owner = this;
            f15.Show();
        }

        private void поНомеруГруппыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Owner = this;
            f16.Show();
        }

        private void поАдрессуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Owner = this;
            f17.Show();
        }
    }
}
