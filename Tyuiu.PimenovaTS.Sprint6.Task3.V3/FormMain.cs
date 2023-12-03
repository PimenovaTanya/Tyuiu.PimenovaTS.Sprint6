using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PimenovaTS.Sprint6.Task3.V3.Lib;

namespace Tyuiu.PimenovaTS.Sprint6.Task3.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -18, 21, 10, -2, 12 }, { -18, -10, 33, -20, 32 }, { 14, -15, -14, 12, -18 }, { -19, 5, -3, 28, -17 }, { -14, -9, 23, -13, 11 } };


        private void buttonDone_PTS_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;

            dataGridViewResult_PTS.ColumnCount = columns;
            dataGridViewResult_PTS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_PTS.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_PTS.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_PTS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб-23-2 Пименова Татьяна Сергеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewMatr_PTS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatr_PTS.ColumnCount = columns;
            dataGridViewMatr_PTS.RowCount = rows;

            for (int i =  0; i < columns; i++)
            {
                dataGridViewMatr_PTS.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatr_PTS.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
