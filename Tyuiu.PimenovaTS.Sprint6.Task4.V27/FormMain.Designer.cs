
namespace Tyuiu.PimenovaTS.Sprint6.Task4.V27
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_PTS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PTS = new System.Windows.Forms.TextBox();
            this.groupBoxInput_PTS = new System.Windows.Forms.GroupBox();
            this.labelStart_PTS = new System.Windows.Forms.Label();
            this.labelStop_PTS = new System.Windows.Forms.Label();
            this.textBoxStart_PTS = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxStop_PTS = new System.Windows.Forms.TextBox();
            this.buttonDone_PTS = new System.Windows.Forms.Button();
            this.buttonSave_PTS = new System.Windows.Forms.Button();
            this.buttonHelp_PTS = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxConclusion_PTS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_PTS = new System.Windows.Forms.TextBox();
            this.chartFunction_PTS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_PTS.SuspendLayout();
            this.groupBoxInput_PTS.SuspendLayout();
            this.groupBoxConclusion_PTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PTS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_PTS
            // 
            this.groupBoxTask_PTS.Controls.Add(this.textBoxTask_PTS);
            this.groupBoxTask_PTS.Location = new System.Drawing.Point(13, 12);
            this.groupBoxTask_PTS.Name = "groupBoxTask_PTS";
            this.groupBoxTask_PTS.Size = new System.Drawing.Size(510, 77);
            this.groupBoxTask_PTS.TabIndex = 0;
            this.groupBoxTask_PTS.TabStop = false;
            this.groupBoxTask_PTS.Text = "Условие";
            // 
            // textBoxTask_PTS
            // 
            this.textBoxTask_PTS.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_PTS.Multiline = true;
            this.textBoxTask_PTS.Name = "textBoxTask_PTS";
            this.textBoxTask_PTS.Size = new System.Drawing.Size(503, 55);
            this.textBoxTask_PTS.TabIndex = 0;
            this.textBoxTask_PTS.Text = resources.GetString("textBoxTask_PTS.Text");
            this.textBoxTask_PTS.TextChanged += new System.EventHandler(this.textBoxTask_PTS_TextChanged);
            // 
            // groupBoxInput_PTS
            // 
            this.groupBoxInput_PTS.Controls.Add(this.textBoxStop_PTS);
            this.groupBoxInput_PTS.Controls.Add(this.textBox2);
            this.groupBoxInput_PTS.Controls.Add(this.textBoxStart_PTS);
            this.groupBoxInput_PTS.Controls.Add(this.labelStop_PTS);
            this.groupBoxInput_PTS.Controls.Add(this.labelStart_PTS);
            this.groupBoxInput_PTS.Location = new System.Drawing.Point(529, 13);
            this.groupBoxInput_PTS.Name = "groupBoxInput_PTS";
            this.groupBoxInput_PTS.Size = new System.Drawing.Size(259, 76);
            this.groupBoxInput_PTS.TabIndex = 1;
            this.groupBoxInput_PTS.TabStop = false;
            this.groupBoxInput_PTS.Text = "Ввод данных:";
            // 
            // labelStart_PTS
            // 
            this.labelStart_PTS.AutoSize = true;
            this.labelStart_PTS.Location = new System.Drawing.Point(7, 22);
            this.labelStart_PTS.Name = "labelStart_PTS";
            this.labelStart_PTS.Size = new System.Drawing.Size(87, 17);
            this.labelStart_PTS.TabIndex = 0;
            this.labelStart_PTS.Text = "Старт шага:";
            // 
            // labelStop_PTS
            // 
            this.labelStop_PTS.AutoSize = true;
            this.labelStop_PTS.Location = new System.Drawing.Point(121, 22);
            this.labelStop_PTS.Name = "labelStop_PTS";
            this.labelStop_PTS.Size = new System.Drawing.Size(89, 17);
            this.labelStop_PTS.TabIndex = 0;
            this.labelStop_PTS.Text = "Конец шага:";
            // 
            // textBoxStart_PTS
            // 
            this.textBoxStart_PTS.Location = new System.Drawing.Point(10, 43);
            this.textBoxStart_PTS.Name = "textBoxStart_PTS";
            this.textBoxStart_PTS.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_PTS.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBoxStop_PTS
            // 
            this.textBoxStop_PTS.Location = new System.Drawing.Point(124, 43);
            this.textBoxStop_PTS.Name = "textBoxStop_PTS";
            this.textBoxStop_PTS.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_PTS.TabIndex = 1;
            // 
            // buttonDone_PTS
            // 
            this.buttonDone_PTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDone_PTS.Location = new System.Drawing.Point(794, 13);
            this.buttonDone_PTS.Name = "buttonDone_PTS";
            this.buttonDone_PTS.Size = new System.Drawing.Size(103, 76);
            this.buttonDone_PTS.TabIndex = 2;
            this.buttonDone_PTS.Text = "Выполнить";
            this.buttonDone_PTS.UseVisualStyleBackColor = false;
            this.buttonDone_PTS.Click += new System.EventHandler(this.buttonDone_PTS_Click);
            // 
            // buttonSave_PTS
            // 
            this.buttonSave_PTS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSave_PTS.Location = new System.Drawing.Point(903, 12);
            this.buttonSave_PTS.Name = "buttonSave_PTS";
            this.buttonSave_PTS.Size = new System.Drawing.Size(103, 76);
            this.buttonSave_PTS.TabIndex = 2;
            this.buttonSave_PTS.Text = "Сохранить";
            this.buttonSave_PTS.UseVisualStyleBackColor = false;
            this.buttonSave_PTS.Click += new System.EventHandler(this.buttonSave_PTS_Click);
            // 
            // buttonHelp_PTS
            // 
            this.buttonHelp_PTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonHelp_PTS.Location = new System.Drawing.Point(1012, 12);
            this.buttonHelp_PTS.Name = "buttonHelp_PTS";
            this.buttonHelp_PTS.Size = new System.Drawing.Size(103, 76);
            this.buttonHelp_PTS.TabIndex = 2;
            this.buttonHelp_PTS.Text = "Справка";
            this.buttonHelp_PTS.UseVisualStyleBackColor = false;
            this.buttonHelp_PTS.Click += new System.EventHandler(this.buttonHelp_PTS_Click);
            // 
            // groupBoxConclusion_PTS
            // 
            this.groupBoxConclusion_PTS.Controls.Add(this.textBoxResult_PTS);
            this.groupBoxConclusion_PTS.Location = new System.Drawing.Point(20, 96);
            this.groupBoxConclusion_PTS.Name = "groupBoxConclusion_PTS";
            this.groupBoxConclusion_PTS.Size = new System.Drawing.Size(242, 394);
            this.groupBoxConclusion_PTS.TabIndex = 3;
            this.groupBoxConclusion_PTS.TabStop = false;
            this.groupBoxConclusion_PTS.Text = "Вывод данных:";
            // 
            // textBoxResult_PTS
            // 
            this.textBoxResult_PTS.Location = new System.Drawing.Point(7, 22);
            this.textBoxResult_PTS.Multiline = true;
            this.textBoxResult_PTS.Name = "textBoxResult_PTS";
            this.textBoxResult_PTS.Size = new System.Drawing.Size(229, 366);
            this.textBoxResult_PTS.TabIndex = 0;
            // 
            // chartFunction_PTS
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction_PTS.ChartAreas.Add(chartArea4);
            this.chartFunction_PTS.Location = new System.Drawing.Point(284, 102);
            this.chartFunction_PTS.Name = "chartFunction_PTS";
            this.chartFunction_PTS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Name = "Series1";
            this.chartFunction_PTS.Series.Add(series4);
            this.chartFunction_PTS.Size = new System.Drawing.Size(831, 388);
            this.chartFunction_PTS.TabIndex = 4;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.ForeColor = System.Drawing.Color.Blue;
            title4.Name = "Title1";
            title4.Text = "График функции (cos(x)/x+1)-cos(x)*1.3+3*x";
            this.chartFunction_PTS.Titles.Add(title4);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 453);
            this.Controls.Add(this.chartFunction_PTS);
            this.Controls.Add(this.groupBoxConclusion_PTS);
            this.Controls.Add(this.buttonHelp_PTS);
            this.Controls.Add(this.buttonSave_PTS);
            this.Controls.Add(this.buttonDone_PTS);
            this.Controls.Add(this.groupBoxInput_PTS);
            this.Controls.Add(this.groupBoxTask_PTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_PTS.ResumeLayout(false);
            this.groupBoxTask_PTS.PerformLayout();
            this.groupBoxInput_PTS.ResumeLayout(false);
            this.groupBoxInput_PTS.PerformLayout();
            this.groupBoxConclusion_PTS.ResumeLayout(false);
            this.groupBoxConclusion_PTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PTS;
        private System.Windows.Forms.TextBox textBoxTask_PTS;
        private System.Windows.Forms.GroupBox groupBoxInput_PTS;
        private System.Windows.Forms.TextBox textBoxStop_PTS;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxStart_PTS;
        private System.Windows.Forms.Label labelStop_PTS;
        private System.Windows.Forms.Label labelStart_PTS;
        private System.Windows.Forms.Button buttonDone_PTS;
        private System.Windows.Forms.Button buttonSave_PTS;
        private System.Windows.Forms.Button buttonHelp_PTS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxConclusion_PTS;
        private System.Windows.Forms.TextBox textBoxResult_PTS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PTS;
    }
}

