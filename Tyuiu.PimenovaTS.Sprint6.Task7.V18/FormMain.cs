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
using Tyuiu.PimenovaTS.Sprint6.Task7.V18.Lib;

namespace Tyuiu.PimenovaTS.Sprint6.Task7.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_PTS.Filter = "Значенияб разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            openFileDialogMatrix_PTS.Filter = "Значенияб разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewDataEntry_PTS.ColumnCount = 50;
            dataGridViewDataOutPut_PTS.ColumnCount = 50;

            dataGridViewDataOutPut_PTS.RowCount = 50;
            dataGridViewDataEntry_PTS.RowCount = 50;
        }

        private void buttonOpenFile_PTS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PTS.ShowDialog();
            openFilePath = openFileDialogTask_PTS.FileName;

            int[,] arrayValue = new int[rows, columns];

            arrayValue = LoadFromData(openFilePath);

            dataGridViewDataEntry_PTS.ColumnCount = columns;
            dataGridViewDataEntry_PTS.RowCount = rows;
            dataGridViewDataOutPut_PTS.ColumnCount = columns;
            dataGridViewDataOutPut_PTS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewDataEntry_PTS.Columns[i].Width = 25;
                dataGridViewDataOutPut_PTS.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewDataEntry_PTS.Rows[r].Cells[c].Value = arrayValue[r, c];
                }
            }

            arrayValue = ds.GetMatrix(openFilePath);
            buttonDone_PTS.Enabled = true;
        }

        private void buttonHelp_PTS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_PTS_Click(object sender, EventArgs e)
        {
            int[,] arrayValue = new int[rows, columns];
            arrayValue = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewDataOutPut_PTS.Rows[r].Cells[c].Value = arrayValue[r, c];
                }
            }
            buttonSave_PTS.Enabled = true;
        }

        private void buttonSave_PTS_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_PTS.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_PTS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_PTS.ShowDialog();

            string path = saveFileDialogMatrix_PTS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }


            int rows = dataGridViewDataOutPut_PTS.RowCount;
            int columns = dataGridViewDataOutPut_PTS.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewDataOutPut_PTS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewDataOutPut_PTS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}
