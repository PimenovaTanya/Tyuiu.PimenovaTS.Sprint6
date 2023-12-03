
namespace Tyuiu.PimenovaTS.Sprint6.Task3.V3
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
            this.groupBoxTask_PTS = new System.Windows.Forms.GroupBox();
            this.groupBoxConclusion_PTS = new System.Windows.Forms.GroupBox();
            this.buttonDone_PTS = new System.Windows.Forms.Button();
            this.buttonHelp_PTS = new System.Windows.Forms.Button();
            this.textBoxTask_PTS = new System.Windows.Forms.TextBox();
            this.dataGridViewMatr_PTS = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult_PTS = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_PTS.SuspendLayout();
            this.groupBoxConclusion_PTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatr_PTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PTS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_PTS
            // 
            this.groupBoxTask_PTS.Controls.Add(this.dataGridViewMatr_PTS);
            this.groupBoxTask_PTS.Controls.Add(this.textBoxTask_PTS);
            this.groupBoxTask_PTS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_PTS.Name = "groupBoxTask_PTS";
            this.groupBoxTask_PTS.Size = new System.Drawing.Size(678, 364);
            this.groupBoxTask_PTS.TabIndex = 0;
            this.groupBoxTask_PTS.TabStop = false;
            this.groupBoxTask_PTS.Text = "Условие";
            // 
            // groupBoxConclusion_PTS
            // 
            this.groupBoxConclusion_PTS.Controls.Add(this.dataGridViewResult_PTS);
            this.groupBoxConclusion_PTS.Controls.Add(this.buttonHelp_PTS);
            this.groupBoxConclusion_PTS.Controls.Add(this.buttonDone_PTS);
            this.groupBoxConclusion_PTS.Location = new System.Drawing.Point(697, 13);
            this.groupBoxConclusion_PTS.Name = "groupBoxConclusion_PTS";
            this.groupBoxConclusion_PTS.Size = new System.Drawing.Size(333, 364);
            this.groupBoxConclusion_PTS.TabIndex = 1;
            this.groupBoxConclusion_PTS.TabStop = false;
            this.groupBoxConclusion_PTS.Text = "Вывод данных";
            // 
            // buttonDone_PTS
            // 
            this.buttonDone_PTS.Location = new System.Drawing.Point(202, 329);
            this.buttonDone_PTS.Name = "buttonDone_PTS";
            this.buttonDone_PTS.Size = new System.Drawing.Size(125, 29);
            this.buttonDone_PTS.TabIndex = 0;
            this.buttonDone_PTS.Text = "Выполнить";
            this.buttonDone_PTS.UseVisualStyleBackColor = true;
            this.buttonDone_PTS.Click += new System.EventHandler(this.buttonDone_PTS_Click);
            // 
            // buttonHelp_PTS
            // 
            this.buttonHelp_PTS.Location = new System.Drawing.Point(145, 329);
            this.buttonHelp_PTS.Name = "buttonHelp_PTS";
            this.buttonHelp_PTS.Size = new System.Drawing.Size(37, 29);
            this.buttonHelp_PTS.TabIndex = 0;
            this.buttonHelp_PTS.Text = "?";
            this.buttonHelp_PTS.UseVisualStyleBackColor = true;
            this.buttonHelp_PTS.Click += new System.EventHandler(this.buttonHelp_PTS_Click);
            // 
            // textBoxTask_PTS
            // 
            this.textBoxTask_PTS.Location = new System.Drawing.Point(6, 22);
            this.textBoxTask_PTS.Multiline = true;
            this.textBoxTask_PTS.Name = "textBoxTask_PTS";
            this.textBoxTask_PTS.ReadOnly = true;
            this.textBoxTask_PTS.Size = new System.Drawing.Size(343, 336);
            this.textBoxTask_PTS.TabIndex = 0;
            this.textBoxTask_PTS.Text = "Дана матрица 5 на 5\r\n-18  21  10   -2    12\r\n-18 -10  33  -20  32\r\n 14   15 -14 1" +
    "2  -18\r\n-19   5   -3   28   -17\r\n-14   -9  23 -13   11\r\nВыполнить сортировку по " +
    "возрастанию во втором столбце";
            // 
            // dataGridViewMatr_PTS
            // 
            this.dataGridViewMatr_PTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatr_PTS.Location = new System.Drawing.Point(355, 22);
            this.dataGridViewMatr_PTS.Name = "dataGridViewMatr_PTS";
            this.dataGridViewMatr_PTS.RowHeadersVisible = false;
            this.dataGridViewMatr_PTS.RowHeadersWidth = 51;
            this.dataGridViewMatr_PTS.RowTemplate.Height = 24;
            this.dataGridViewMatr_PTS.Size = new System.Drawing.Size(322, 336);
            this.dataGridViewMatr_PTS.TabIndex = 1;
            this.dataGridViewMatr_PTS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatr_PTS_CellContentClick);
            // 
            // dataGridViewResult_PTS
            // 
            this.dataGridViewResult_PTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_PTS.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewResult_PTS.Name = "dataGridViewResult_PTS";
            this.dataGridViewResult_PTS.RowHeadersVisible = false;
            this.dataGridViewResult_PTS.RowHeadersWidth = 51;
            this.dataGridViewResult_PTS.RowTemplate.Height = 24;
            this.dataGridViewResult_PTS.Size = new System.Drawing.Size(321, 302);
            this.dataGridViewResult_PTS.TabIndex = 1;
            this.dataGridViewResult_PTS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatr_PTS_CellContentClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 389);
            this.Controls.Add(this.groupBoxConclusion_PTS);
            this.Controls.Add(this.groupBoxTask_PTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 3 | Пименова Т. С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_PTS.ResumeLayout(false);
            this.groupBoxTask_PTS.PerformLayout();
            this.groupBoxConclusion_PTS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatr_PTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PTS;
        private System.Windows.Forms.DataGridView dataGridViewMatr_PTS;
        private System.Windows.Forms.TextBox textBoxTask_PTS;
        private System.Windows.Forms.GroupBox groupBoxConclusion_PTS;
        private System.Windows.Forms.Button buttonHelp_PTS;
        private System.Windows.Forms.Button buttonDone_PTS;
        private System.Windows.Forms.DataGridView dataGridViewResult_PTS;
    }
}

