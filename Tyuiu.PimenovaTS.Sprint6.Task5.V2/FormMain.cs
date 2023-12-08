using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PimenovaTS.Sprint6.Task5.V2.Lib;

namespace Tyuiu.PimenovaTS.Sprint6.Task5.V2
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\User\source\repos\Tyuiu.PimenovaTS.Sprint6\Tyuiu.PimenovaTS.Sprint6.Task5.V2\bin\Debug\InPutFileTask5V2.txt";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void buttonDone_PTS_Click(object sender, EventArgs e)
        {
            dataGridViewResult_PTS.ColumnCount = 2;
            dataGridViewResult_PTS.Columns[0].Width = 20;
            dataGridViewResult_PTS.Columns[1].Width = 50;

            this.chartDiag_PTS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_PTS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_PTS.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_PTS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_PTS.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_PTS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_PTS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-23-2 Пименова Татьяна Сергеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
