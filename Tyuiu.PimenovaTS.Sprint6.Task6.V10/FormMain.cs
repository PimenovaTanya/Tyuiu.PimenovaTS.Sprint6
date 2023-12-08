using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.PimenovaTS.Sprint6.Task6.V10.Lib;

namespace Tyuiu.PimenovaTS.Sprint6.Task6.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path;

        private void buttonOpen_PTS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PTS.ShowDialog();
            path = openFileDialogTask_PTS.FileName;
            textBoxInPut_PTS.Text = File.ReadAllText(path);
            groupBoxResult_PTS.Text = groupBoxResult_PTS.Text + " " + openFileDialogTask_PTS.FileName;
            buttonDone_PTS.Enabled = true;
        }

        private void buttonDone_PTS_Click(object sender, EventArgs e)
        {
            textBoxResult_PTS.Text = ds.CollectTextFromFile(path);
        }

        private void buttonHelp_PTS_Click(object sender, EventArgs e)
        {
            FormAboutProgram_PTS formAbout = new FormAboutProgram_PTS();
            formAbout.ShowDialog();
        }
    }
}
