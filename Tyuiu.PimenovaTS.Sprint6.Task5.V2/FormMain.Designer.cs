
namespace Tyuiu.PimenovaTS.Sprint6.Task5.V2
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
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxTask_PTS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PTS = new System.Windows.Forms.TextBox();
            this.buttonDone_PTS = new System.Windows.Forms.Button();
            this.buttonOpen_PTS = new System.Windows.Forms.Button();
            this.buttonHelp_PTS = new System.Windows.Forms.Button();
            this.groupBoxConclusion_PTS = new System.Windows.Forms.GroupBox();
            this.chartDiag_PTS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult_PTS = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxTask_PTS.SuspendLayout();
            this.groupBoxConclusion_PTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_PTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PTS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp_PTS);
            this.panel1.Controls.Add(this.buttonOpen_PTS);
            this.panel1.Controls.Add(this.buttonDone_PTS);
            this.panel1.Controls.Add(this.groupBoxTask_PTS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 86);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxConclusion_PTS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 317);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartDiag_PTS);
            this.panel3.Controls.Add(this.splitter1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(203, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 317);
            this.panel3.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 317);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // groupBoxTask_PTS
            // 
            this.groupBoxTask_PTS.Controls.Add(this.textBoxTask_PTS);
            this.groupBoxTask_PTS.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_PTS.Name = "groupBoxTask_PTS";
            this.groupBoxTask_PTS.Size = new System.Drawing.Size(439, 79);
            this.groupBoxTask_PTS.TabIndex = 0;
            this.groupBoxTask_PTS.TabStop = false;
            this.groupBoxTask_PTS.Text = "Условие:";
            // 
            // textBoxTask_PTS
            // 
            this.textBoxTask_PTS.Location = new System.Drawing.Point(1, 22);
            this.textBoxTask_PTS.Multiline = true;
            this.textBoxTask_PTS.Name = "textBoxTask_PTS";
            this.textBoxTask_PTS.Size = new System.Drawing.Size(438, 57);
            this.textBoxTask_PTS.TabIndex = 0;
            this.textBoxTask_PTS.Text = "Прочитать данные из файла InPutFileTask5V2.txt. Вывести в DataGridView отрицатель" +
    "ные значения и построить диаграмму по этим значениям.";
            // 
            // buttonDone_PTS
            // 
            this.buttonDone_PTS.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonDone_PTS.Location = new System.Drawing.Point(449, 12);
            this.buttonDone_PTS.Name = "buttonDone_PTS";
            this.buttonDone_PTS.Size = new System.Drawing.Size(123, 67);
            this.buttonDone_PTS.TabIndex = 1;
            this.buttonDone_PTS.Text = "Выполнить";
            this.buttonDone_PTS.UseVisualStyleBackColor = false;
            this.buttonDone_PTS.Click += new System.EventHandler(this.buttonDone_PTS_Click);
            // 
            // buttonOpen_PTS
            // 
            this.buttonOpen_PTS.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonOpen_PTS.Location = new System.Drawing.Point(578, 12);
            this.buttonOpen_PTS.Name = "buttonOpen_PTS";
            this.buttonOpen_PTS.Size = new System.Drawing.Size(93, 67);
            this.buttonOpen_PTS.TabIndex = 1;
            this.buttonOpen_PTS.Text = "Открыть файл";
            this.buttonOpen_PTS.UseVisualStyleBackColor = false;
            this.buttonOpen_PTS.Click += new System.EventHandler(this.buttonOpen_PTS_Click);
            // 
            // buttonHelp_PTS
            // 
            this.buttonHelp_PTS.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonHelp_PTS.Location = new System.Drawing.Point(677, 13);
            this.buttonHelp_PTS.Name = "buttonHelp_PTS";
            this.buttonHelp_PTS.Size = new System.Drawing.Size(93, 67);
            this.buttonHelp_PTS.TabIndex = 1;
            this.buttonHelp_PTS.Text = "Справка";
            this.buttonHelp_PTS.UseVisualStyleBackColor = false;
            this.buttonHelp_PTS.Click += new System.EventHandler(this.buttonHelp_PTS_Click);
            // 
            // groupBoxConclusion_PTS
            // 
            this.groupBoxConclusion_PTS.Controls.Add(this.dataGridViewResult_PTS);
            this.groupBoxConclusion_PTS.Location = new System.Drawing.Point(4, 0);
            this.groupBoxConclusion_PTS.Name = "groupBoxConclusion_PTS";
            this.groupBoxConclusion_PTS.Size = new System.Drawing.Size(200, 314);
            this.groupBoxConclusion_PTS.TabIndex = 0;
            this.groupBoxConclusion_PTS.TabStop = false;
            this.groupBoxConclusion_PTS.Text = "Вывод данных:";
            // 
            // chartDiag_PTS
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDiag_PTS.ChartAreas.Add(chartArea4);
            this.chartDiag_PTS.Location = new System.Drawing.Point(4, 0);
            this.chartDiag_PTS.Name = "chartDiag_PTS";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.chartDiag_PTS.Series.Add(series4);
            this.chartDiag_PTS.Size = new System.Drawing.Size(572, 317);
            this.chartDiag_PTS.TabIndex = 1;
            this.chartDiag_PTS.Text = "chart1";
            // 
            // dataGridViewResult_PTS
            // 
            this.dataGridViewResult_PTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_PTS.Location = new System.Drawing.Point(-4, 21);
            this.dataGridViewResult_PTS.Name = "dataGridViewResult_PTS";
            this.dataGridViewResult_PTS.RowHeadersVisible = false;
            this.dataGridViewResult_PTS.RowHeadersWidth = 51;
            this.dataGridViewResult_PTS.RowTemplate.Height = 24;
            this.dataGridViewResult_PTS.Size = new System.Drawing.Size(201, 293);
            this.dataGridViewResult_PTS.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 2 | Пименова Т. С.";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBoxTask_PTS.ResumeLayout(false);
            this.groupBoxTask_PTS.PerformLayout();
            this.groupBoxConclusion_PTS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_PTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonHelp_PTS;
        private System.Windows.Forms.Button buttonOpen_PTS;
        private System.Windows.Forms.Button buttonDone_PTS;
        private System.Windows.Forms.GroupBox groupBoxTask_PTS;
        private System.Windows.Forms.TextBox textBoxTask_PTS;
        private System.Windows.Forms.GroupBox groupBoxConclusion_PTS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_PTS;
        private System.Windows.Forms.DataGridView dataGridViewResult_PTS;
    }
}

