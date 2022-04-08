using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2_PABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            //membuat tulisan header tabel bold (tebal)
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);

            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Salmon;
            this.dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Orange;
            this.dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Green;
            this.dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.Blue;
            this.dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.DarkRed;

            this.dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.CadetBlue;
            this.dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            this.dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Maroon;
            this.dataGridView1.BackgroundColor = Color.Black;

            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        { 

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
