using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PimenovaTS.Sprint6.Task1.V8.Lib;

namespace Tyuiu.PimenovaTS.Sprint6.Task1.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelCondtion_PTS_Click(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();
        private void buttonDone_PTS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_PTS.Text);
                int stopStep = Convert.ToInt32(textBoxStop_PTS.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_PTS.Text = "";
                textBoxResult_PTS.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_PTS.AppendText("|    X     |   f(X)   |" + Environment.NewLine);
                textBoxResult_PTS.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}  | ", startStep, valueArray[i]);
                    textBoxResult_PTS.AppendText(strLine )
                }
            }
        }
    }
}
