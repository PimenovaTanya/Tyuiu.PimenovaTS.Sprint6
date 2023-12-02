using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PimenovaTS.Sprint6.Task2.V18.Lib;

namespace Tyuiu.PimenovaTS.Sprint6.Task2.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonHelp_PTS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-23-2 Пименова Татьяна Сергеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_PTS_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_PTS.Text);
                int stopValue = Convert.ToInt32(textBoxStop_PTS.Text);
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_PTS.Titles.Add("График функции  (3cos(x)) / (4x-0.5) + sin(x) - 5x - 2");

                this.chartFunction_PTS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PTS.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_PTS.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chartFunction_PTS.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }
            }
            catch
            {

                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //
        }

        private void chartFunction_PTS_Click(object sender, EventArgs e)
        {
            //
        }

        private void buttonDone_PTS_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_PTS.BackColor = Color.Red;
        }

        private void buttonDone_PTS_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PTS.BackColor = Color.Green;
        }

        private void buttonDone_PTS_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_PTS.BackColor = Color.Blue;
        }
    }
}
