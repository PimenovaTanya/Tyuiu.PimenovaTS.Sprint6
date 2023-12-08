
namespace Tyuiu.PimenovaTS.Sprint6.Task6.V10
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxTask_PTS = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_PTS = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_PTS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PTS = new System.Windows.Forms.TextBox();
            this.textBoxInPut_PTS = new System.Windows.Forms.TextBox();
            this.textBoxResult_PTS = new System.Windows.Forms.TextBox();
            this.buttonOpen_PTS = new System.Windows.Forms.Button();
            this.buttonDone_PTS = new System.Windows.Forms.Button();
            this.buttonHelp_PTS = new System.Windows.Forms.Button();
            this.openFileDialogTask_PTS = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxTask_PTS.SuspendLayout();
            this.groupBoxInPut_PTS.SuspendLayout();
            this.groupBoxResult_PTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp_PTS);
            this.panel1.Controls.Add(this.buttonDone_PTS);
            this.panel1.Controls.Add(this.buttonOpen_PTS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 76);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxTask_PTS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 60);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxInPut_PTS);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 422);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBoxResult_PTS);
            this.panel4.Controls.Add(this.splitter1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(543, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 422);
            this.panel4.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 422);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // groupBoxTask_PTS
            // 
            this.groupBoxTask_PTS.Controls.Add(this.textBoxTask_PTS);
            this.groupBoxTask_PTS.Location = new System.Drawing.Point(0, 3);
            this.groupBoxTask_PTS.Name = "groupBoxTask_PTS";
            this.groupBoxTask_PTS.Size = new System.Drawing.Size(1065, 60);
            this.groupBoxTask_PTS.TabIndex = 0;
            this.groupBoxTask_PTS.TabStop = false;
            this.groupBoxTask_PTS.Text = "Условие:";
            // 
            // groupBoxInPut_PTS
            // 
            this.groupBoxInPut_PTS.Controls.Add(this.textBoxInPut_PTS);
            this.groupBoxInPut_PTS.Location = new System.Drawing.Point(6, 6);
            this.groupBoxInPut_PTS.Name = "groupBoxInPut_PTS";
            this.groupBoxInPut_PTS.Size = new System.Drawing.Size(534, 413);
            this.groupBoxInPut_PTS.TabIndex = 0;
            this.groupBoxInPut_PTS.TabStop = false;
            this.groupBoxInPut_PTS.Text = "Ввод:";
            // 
            // groupBoxResult_PTS
            // 
            this.groupBoxResult_PTS.Controls.Add(this.textBoxResult_PTS);
            this.groupBoxResult_PTS.Location = new System.Drawing.Point(3, 0);
            this.groupBoxResult_PTS.Name = "groupBoxResult_PTS";
            this.groupBoxResult_PTS.Size = new System.Drawing.Size(513, 416);
            this.groupBoxResult_PTS.TabIndex = 0;
            this.groupBoxResult_PTS.TabStop = false;
            this.groupBoxResult_PTS.Text = "Вывод:";
            // 
            // textBoxTask_PTS
            // 
            this.textBoxTask_PTS.Location = new System.Drawing.Point(0, 22);
            this.textBoxTask_PTS.Multiline = true;
            this.textBoxTask_PTS.Name = "textBoxTask_PTS";
            this.textBoxTask_PTS.Size = new System.Drawing.Size(1065, 38);
            this.textBoxTask_PTS.TabIndex = 0;
            this.textBoxTask_PTS.Text = resources.GetString("textBoxTask_PTS.Text");
            // 
            // textBoxInPut_PTS
            // 
            this.textBoxInPut_PTS.Location = new System.Drawing.Point(12, 21);
            this.textBoxInPut_PTS.Multiline = true;
            this.textBoxInPut_PTS.Name = "textBoxInPut_PTS";
            this.textBoxInPut_PTS.Size = new System.Drawing.Size(525, 389);
            this.textBoxInPut_PTS.TabIndex = 0;
            // 
            // textBoxResult_PTS
            // 
            this.textBoxResult_PTS.Location = new System.Drawing.Point(9, 27);
            this.textBoxResult_PTS.Multiline = true;
            this.textBoxResult_PTS.Name = "textBoxResult_PTS";
            this.textBoxResult_PTS.Size = new System.Drawing.Size(498, 389);
            this.textBoxResult_PTS.TabIndex = 0;
            // 
            // buttonOpen_PTS
            // 
            this.buttonOpen_PTS.BackColor = System.Drawing.Color.Red;
            this.buttonOpen_PTS.Location = new System.Drawing.Point(4, 4);
            this.buttonOpen_PTS.Name = "buttonOpen_PTS";
            this.buttonOpen_PTS.Size = new System.Drawing.Size(105, 66);
            this.buttonOpen_PTS.TabIndex = 0;
            this.buttonOpen_PTS.Text = "Открыть файл";
            this.toolTip1.SetToolTip(this.buttonOpen_PTS, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpen_PTS.UseVisualStyleBackColor = false;
            this.buttonOpen_PTS.Click += new System.EventHandler(this.buttonOpen_PTS_Click);
            // 
            // buttonDone_PTS
            // 
            this.buttonDone_PTS.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDone_PTS.Location = new System.Drawing.Point(115, 4);
            this.buttonDone_PTS.Name = "buttonDone_PTS";
            this.buttonDone_PTS.Size = new System.Drawing.Size(105, 66);
            this.buttonDone_PTS.TabIndex = 0;
            this.buttonDone_PTS.Text = "Выполнить";
            this.toolTip2.SetToolTip(this.buttonDone_PTS, "Производит поиск слов в которых встречается w");
            this.buttonDone_PTS.UseVisualStyleBackColor = false;
            this.buttonDone_PTS.Click += new System.EventHandler(this.buttonDone_PTS_Click);
            // 
            // buttonHelp_PTS
            // 
            this.buttonHelp_PTS.BackColor = System.Drawing.Color.Maroon;
            this.buttonHelp_PTS.Location = new System.Drawing.Point(957, 4);
            this.buttonHelp_PTS.Name = "buttonHelp_PTS";
            this.buttonHelp_PTS.Size = new System.Drawing.Size(105, 66);
            this.buttonHelp_PTS.TabIndex = 0;
            this.buttonHelp_PTS.Text = "Справка";
            this.buttonHelp_PTS.UseVisualStyleBackColor = false;
            this.buttonHelp_PTS.Click += new System.EventHandler(this.buttonHelp_PTS_Click);
            // 
            // openFileDialogTask_PTS
            // 
            this.openFileDialogTask_PTS.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 558);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариан 10 | Пименова Т. С.";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBoxTask_PTS.ResumeLayout(false);
            this.groupBoxTask_PTS.PerformLayout();
            this.groupBoxInPut_PTS.ResumeLayout(false);
            this.groupBoxInPut_PTS.PerformLayout();
            this.groupBoxResult_PTS.ResumeLayout(false);
            this.groupBoxResult_PTS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp_PTS;
        private System.Windows.Forms.Button buttonDone_PTS;
        private System.Windows.Forms.Button buttonOpen_PTS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxTask_PTS;
        private System.Windows.Forms.TextBox textBoxTask_PTS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxInPut_PTS;
        private System.Windows.Forms.TextBox textBoxInPut_PTS;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBoxResult_PTS;
        private System.Windows.Forms.TextBox textBoxResult_PTS;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_PTS;
    }
}

