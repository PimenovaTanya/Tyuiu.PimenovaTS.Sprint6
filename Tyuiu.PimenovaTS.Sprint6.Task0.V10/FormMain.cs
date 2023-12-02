﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PimenovaTS.Sprint6.Task0.V10.Lib;

namespace Tyuiu.PimenovaTS.Sprint6.Task0.V10
{
    public partial class FormMain_PTS : Form
    {
        public FormMain_PTS()
        {
            InitializeComponent();
        }

        private void buttonDone_PTS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_PTS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_PTS.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBoxVarX_PTS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_PTS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИИПб-23-2 Пименова Татьяна Сергеевна", "Сообщение");
        }
    }
}
