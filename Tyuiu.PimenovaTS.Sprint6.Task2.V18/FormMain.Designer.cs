
namespace Tyuiu.PimenovaTS.Sprint6.Task2.V18
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_PTS = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_PTS = new System.Windows.Forms.TextBox();
            this.groupBoxInput_PTS = new System.Windows.Forms.GroupBox();
            this.labelStart_PTS = new System.Windows.Forms.Label();
            this.labelStop_PTS = new System.Windows.Forms.Label();
            this.textBoxStart_PTS = new System.Windows.Forms.TextBox();
            this.textBoxStop_PTS = new System.Windows.Forms.TextBox();
            this.buttonHelp_PTS = new System.Windows.Forms.Button();
            this.buttonDone_PTS = new System.Windows.Forms.Button();
            this.groupBoxExit_PTS = new System.Windows.Forms.GroupBox();
            this.chartFunction_PTS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult_PTS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_PTS.SuspendLayout();
            this.groupBoxInput_PTS.SuspendLayout();
            this.groupBoxExit_PTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PTS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_PTS
            // 
            this.groupBoxTask_PTS.Controls.Add(this.textBoxCondition_PTS);
            this.groupBoxTask_PTS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_PTS.Name = "groupBoxTask_PTS";
            this.groupBoxTask_PTS.Size = new System.Drawing.Size(549, 282);
            this.groupBoxTask_PTS.TabIndex = 0;
            this.groupBoxTask_PTS.TabStop = false;
            this.groupBoxTask_PTS.Text = "Условие";
            // 
            // textBoxCondition_PTS
            // 
            this.textBoxCondition_PTS.Location = new System.Drawing.Point(0, 22);
            this.textBoxCondition_PTS.Multiline = true;
            this.textBoxCondition_PTS.Name = "textBoxCondition_PTS";
            this.textBoxCondition_PTS.Size = new System.Drawing.Size(551, 69);
            this.textBoxCondition_PTS.TabIndex = 0;
            this.textBoxCondition_PTS.Text = "Протабулировать функцию 3cos(x)/(4x-0.5)+sin(x)-5x-2 на заданном диапазоне. Резул" +
    "ьтат вывестив DataGridView и построить график функции.";
            // 
            // groupBoxInput_PTS
            // 
            this.groupBoxInput_PTS.Controls.Add(this.textBoxStop_PTS);
            this.groupBoxInput_PTS.Controls.Add(this.textBoxStart_PTS);
            this.groupBoxInput_PTS.Controls.Add(this.labelStop_PTS);
            this.groupBoxInput_PTS.Controls.Add(this.labelStart_PTS);
            this.groupBoxInput_PTS.Location = new System.Drawing.Point(13, 301);
            this.groupBoxInput_PTS.Name = "groupBoxInput_PTS";
            this.groupBoxInput_PTS.Size = new System.Drawing.Size(293, 84);
            this.groupBoxInput_PTS.TabIndex = 1;
            this.groupBoxInput_PTS.TabStop = false;
            this.groupBoxInput_PTS.Text = "Ввод данных";
            // 
            // labelStart_PTS
            // 
            this.labelStart_PTS.AutoSize = true;
            this.labelStart_PTS.Location = new System.Drawing.Point(6, 27);
            this.labelStart_PTS.Name = "labelStart_PTS";
            this.labelStart_PTS.Size = new System.Drawing.Size(87, 17);
            this.labelStart_PTS.TabIndex = 0;
            this.labelStart_PTS.Text = "Старт шага:";
            // 
            // labelStop_PTS
            // 
            this.labelStop_PTS.AutoSize = true;
            this.labelStop_PTS.Location = new System.Drawing.Point(146, 27);
            this.labelStop_PTS.Name = "labelStop_PTS";
            this.labelStop_PTS.Size = new System.Drawing.Size(89, 17);
            this.labelStop_PTS.TabIndex = 0;
            this.labelStop_PTS.Text = "Конец шага:";
            // 
            // textBoxStart_PTS
            // 
            this.textBoxStart_PTS.Location = new System.Drawing.Point(9, 47);
            this.textBoxStart_PTS.Name = "textBoxStart_PTS";
            this.textBoxStart_PTS.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_PTS.TabIndex = 1;
            // 
            // textBoxStop_PTS
            // 
            this.textBoxStop_PTS.Location = new System.Drawing.Point(149, 47);
            this.textBoxStop_PTS.Name = "textBoxStop_PTS";
            this.textBoxStop_PTS.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_PTS.TabIndex = 1;
            // 
            // buttonHelp_PTS
            // 
            this.buttonHelp_PTS.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonHelp_PTS.Location = new System.Drawing.Point(312, 301);
            this.buttonHelp_PTS.Name = "buttonHelp_PTS";
            this.buttonHelp_PTS.Size = new System.Drawing.Size(91, 84);
            this.buttonHelp_PTS.TabIndex = 2;
            this.buttonHelp_PTS.Text = "Справка";
            this.buttonHelp_PTS.UseVisualStyleBackColor = false;
            this.buttonHelp_PTS.Click += new System.EventHandler(this.buttonHelp_PTS_Click);
            // 
            // buttonDone_PTS
            // 
            this.buttonDone_PTS.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PTS.Location = new System.Drawing.Point(409, 301);
            this.buttonDone_PTS.Name = "buttonDone_PTS";
            this.buttonDone_PTS.Size = new System.Drawing.Size(153, 84);
            this.buttonDone_PTS.TabIndex = 2;
            this.buttonDone_PTS.Text = "Выполнить";
            this.buttonDone_PTS.UseVisualStyleBackColor = false;
            this.buttonDone_PTS.Click += new System.EventHandler(this.buttonDone_PTS_Click);
            this.buttonDone_PTS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PTS_MouseDown);
            this.buttonDone_PTS.MouseEnter += new System.EventHandler(this.buttonDone_PTS_MouseEnter);
            this.buttonDone_PTS.MouseLeave += new System.EventHandler(this.buttonDone_PTS_MouseLeave);
            // 
            // groupBoxExit_PTS
            // 
            this.groupBoxExit_PTS.Controls.Add(this.dataGridViewResult_PTS);
            this.groupBoxExit_PTS.Controls.Add(this.chartFunction_PTS);
            this.groupBoxExit_PTS.Location = new System.Drawing.Point(568, 7);
            this.groupBoxExit_PTS.Name = "groupBoxExit_PTS";
            this.groupBoxExit_PTS.Size = new System.Drawing.Size(682, 378);
            this.groupBoxExit_PTS.TabIndex = 3;
            this.groupBoxExit_PTS.TabStop = false;
            this.groupBoxExit_PTS.Text = "Вывод данных:";
            // 
            // chartFunction_PTS
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction_PTS.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartFunction_PTS.Legends.Add(legend4);
            this.chartFunction_PTS.Location = new System.Drawing.Point(199, 34);
            this.chartFunction_PTS.Name = "chartFunction_PTS";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction_PTS.Series.Add(series4);
            this.chartFunction_PTS.Size = new System.Drawing.Size(477, 338);
            this.chartFunction_PTS.TabIndex = 0;
            this.chartFunction_PTS.Text = "chart1";
            this.chartFunction_PTS.Click += new System.EventHandler(this.chartFunction_PTS_Click);
            // 
            // dataGridViewResult_PTS
            // 
            this.dataGridViewResult_PTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_PTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewResult_PTS.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewResult_PTS.Name = "dataGridViewResult_PTS";
            this.dataGridViewResult_PTS.RowHeadersVisible = false;
            this.dataGridViewResult_PTS.RowHeadersWidth = 51;
            this.dataGridViewResult_PTS.RowTemplate.Height = 24;
            this.dataGridViewResult_PTS.Size = new System.Drawing.Size(172, 338);
            this.dataGridViewResult_PTS.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(X)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 388);
            this.Controls.Add(this.groupBoxExit_PTS);
            this.Controls.Add(this.buttonDone_PTS);
            this.Controls.Add(this.buttonHelp_PTS);
            this.Controls.Add(this.groupBoxInput_PTS);
            this.Controls.Add(this.groupBoxTask_PTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 18 | Пименова Т. С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_PTS.ResumeLayout(false);
            this.groupBoxTask_PTS.PerformLayout();
            this.groupBoxInput_PTS.ResumeLayout(false);
            this.groupBoxInput_PTS.PerformLayout();
            this.groupBoxExit_PTS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PTS;
        private System.Windows.Forms.TextBox textBoxCondition_PTS;
        private System.Windows.Forms.GroupBox groupBoxInput_PTS;
        private System.Windows.Forms.TextBox textBoxStop_PTS;
        private System.Windows.Forms.TextBox textBoxStart_PTS;
        private System.Windows.Forms.Label labelStop_PTS;
        private System.Windows.Forms.Label labelStart_PTS;
        private System.Windows.Forms.Button buttonHelp_PTS;
        private System.Windows.Forms.Button buttonDone_PTS;
        private System.Windows.Forms.GroupBox groupBoxExit_PTS;
        private System.Windows.Forms.DataGridView dataGridViewResult_PTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PTS;
    }
}

