
namespace Tyuiu.PimenovaTS.Sprint6.Task1.V8
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
            this.groupBoxCondition_PTS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PTS = new System.Windows.Forms.TextBox();
            this.groupBoxExit_PTS = new System.Windows.Forms.GroupBox();
            this.labelRes_PTS = new System.Windows.Forms.Label();
            this.textBoxResult_PTS = new System.Windows.Forms.TextBox();
            this.groupBoxInput_PTS = new System.Windows.Forms.GroupBox();
            this.textBoxStart_PTS = new System.Windows.Forms.TextBox();
            this.textBoxStop_PTS = new System.Windows.Forms.TextBox();
            this.labelStart_PTS = new System.Windows.Forms.Label();
            this.labelStop_PTS = new System.Windows.Forms.Label();
            this.buttonHelp_PTS = new System.Windows.Forms.Button();
            this.buttonDone_PTS = new System.Windows.Forms.Button();
            this.groupBoxCondition_PTS.SuspendLayout();
            this.groupBoxExit_PTS.SuspendLayout();
            this.groupBoxInput_PTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PTS
            // 
            this.groupBoxCondition_PTS.Controls.Add(this.textBoxTask_PTS);
            this.groupBoxCondition_PTS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_PTS.Name = "groupBoxCondition_PTS";
            this.groupBoxCondition_PTS.Size = new System.Drawing.Size(531, 330);
            this.groupBoxCondition_PTS.TabIndex = 0;
            this.groupBoxCondition_PTS.TabStop = false;
            this.groupBoxCondition_PTS.Text = "Условие";
            // 
            // textBoxTask_PTS
            // 
            this.textBoxTask_PTS.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_PTS.Multiline = true;
            this.textBoxTask_PTS.Name = "textBoxTask_PTS";
            this.textBoxTask_PTS.Size = new System.Drawing.Size(518, 302);
            this.textBoxTask_PTS.TabIndex = 0;
            this.textBoxTask_PTS.Text = "Протабулировать функцию cos(x)/x-0,4+sin(x)*8*x+2 на заданном диапазоне. Результа" +
    "т вывести в виде таблицы.";
            // 
            // groupBoxExit_PTS
            // 
            this.groupBoxExit_PTS.Controls.Add(this.textBoxResult_PTS);
            this.groupBoxExit_PTS.Controls.Add(this.labelRes_PTS);
            this.groupBoxExit_PTS.Location = new System.Drawing.Point(568, 12);
            this.groupBoxExit_PTS.Name = "groupBoxExit_PTS";
            this.groupBoxExit_PTS.Size = new System.Drawing.Size(220, 414);
            this.groupBoxExit_PTS.TabIndex = 1;
            this.groupBoxExit_PTS.TabStop = false;
            this.groupBoxExit_PTS.Text = "Вывод данных";
            // 
            // labelRes_PTS
            // 
            this.labelRes_PTS.AutoSize = true;
            this.labelRes_PTS.Location = new System.Drawing.Point(7, 22);
            this.labelRes_PTS.Name = "labelRes_PTS";
            this.labelRes_PTS.Size = new System.Drawing.Size(80, 17);
            this.labelRes_PTS.TabIndex = 0;
            this.labelRes_PTS.Text = "Результат:";
            // 
            // textBoxResult_PTS
            // 
            this.textBoxResult_PTS.Location = new System.Drawing.Point(6, 43);
            this.textBoxResult_PTS.Multiline = true;
            this.textBoxResult_PTS.Name = "textBoxResult_PTS";
            this.textBoxResult_PTS.Size = new System.Drawing.Size(208, 365);
            this.textBoxResult_PTS.TabIndex = 1;
            // 
            // groupBoxInput_PTS
            // 
            this.groupBoxInput_PTS.Controls.Add(this.labelStop_PTS);
            this.groupBoxInput_PTS.Controls.Add(this.labelStart_PTS);
            this.groupBoxInput_PTS.Controls.Add(this.textBoxStop_PTS);
            this.groupBoxInput_PTS.Controls.Add(this.textBoxStart_PTS);
            this.groupBoxInput_PTS.Location = new System.Drawing.Point(19, 348);
            this.groupBoxInput_PTS.Name = "groupBoxInput_PTS";
            this.groupBoxInput_PTS.Size = new System.Drawing.Size(294, 78);
            this.groupBoxInput_PTS.TabIndex = 2;
            this.groupBoxInput_PTS.TabStop = false;
            this.groupBoxInput_PTS.Text = "Ввод данных ";
            // 
            // textBoxStart_PTS
            // 
            this.textBoxStart_PTS.Location = new System.Drawing.Point(6, 42);
            this.textBoxStart_PTS.Name = "textBoxStart_PTS";
            this.textBoxStart_PTS.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_PTS.TabIndex = 0;
            // 
            // textBoxStop_PTS
            // 
            this.textBoxStop_PTS.Location = new System.Drawing.Point(154, 42);
            this.textBoxStop_PTS.Name = "textBoxStop_PTS";
            this.textBoxStop_PTS.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_PTS.TabIndex = 0;
            // 
            // labelStart_PTS
            // 
            this.labelStart_PTS.AutoSize = true;
            this.labelStart_PTS.Location = new System.Drawing.Point(7, 22);
            this.labelStart_PTS.Name = "labelStart_PTS";
            this.labelStart_PTS.Size = new System.Drawing.Size(87, 17);
            this.labelStart_PTS.TabIndex = 1;
            this.labelStart_PTS.Text = "Старт шага:";
            // 
            // labelStop_PTS
            // 
            this.labelStop_PTS.AutoSize = true;
            this.labelStop_PTS.Location = new System.Drawing.Point(151, 22);
            this.labelStop_PTS.Name = "labelStop_PTS";
            this.labelStop_PTS.Size = new System.Drawing.Size(89, 17);
            this.labelStop_PTS.TabIndex = 1;
            this.labelStop_PTS.Text = "Конец шага:";
            // 
            // buttonHelp_PTS
            // 
            this.buttonHelp_PTS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_PTS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHelp_PTS.Location = new System.Drawing.Point(319, 348);
            this.buttonHelp_PTS.Name = "buttonHelp_PTS";
            this.buttonHelp_PTS.Size = new System.Drawing.Size(93, 78);
            this.buttonHelp_PTS.TabIndex = 3;
            this.buttonHelp_PTS.Text = "Справка";
            this.buttonHelp_PTS.UseVisualStyleBackColor = false;
            // 
            // buttonDone_PTS
            // 
            this.buttonDone_PTS.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PTS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDone_PTS.Location = new System.Drawing.Point(418, 348);
            this.buttonDone_PTS.Name = "buttonDone_PTS";
            this.buttonDone_PTS.Size = new System.Drawing.Size(125, 78);
            this.buttonDone_PTS.TabIndex = 3;
            this.buttonDone_PTS.Text = "Выполнить";
            this.buttonDone_PTS.UseVisualStyleBackColor = false;
            this.buttonDone_PTS.Click += new System.EventHandler(this.buttonDone_PTS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone_PTS);
            this.Controls.Add(this.buttonHelp_PTS);
            this.Controls.Add(this.groupBoxInput_PTS);
            this.Controls.Add(this.groupBoxExit_PTS);
            this.Controls.Add(this.groupBoxCondition_PTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxCondition_PTS.ResumeLayout(false);
            this.groupBoxCondition_PTS.PerformLayout();
            this.groupBoxExit_PTS.ResumeLayout(false);
            this.groupBoxExit_PTS.PerformLayout();
            this.groupBoxInput_PTS.ResumeLayout(false);
            this.groupBoxInput_PTS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PTS;
        private System.Windows.Forms.TextBox textBoxTask_PTS;
        private System.Windows.Forms.GroupBox groupBoxExit_PTS;
        private System.Windows.Forms.TextBox textBoxResult_PTS;
        private System.Windows.Forms.Label labelRes_PTS;
        private System.Windows.Forms.GroupBox groupBoxInput_PTS;
        private System.Windows.Forms.Label labelStop_PTS;
        private System.Windows.Forms.Label labelStart_PTS;
        private System.Windows.Forms.TextBox textBoxStop_PTS;
        private System.Windows.Forms.TextBox textBoxStart_PTS;
        private System.Windows.Forms.Button buttonHelp_PTS;
        private System.Windows.Forms.Button buttonDone_PTS;
    }
}

