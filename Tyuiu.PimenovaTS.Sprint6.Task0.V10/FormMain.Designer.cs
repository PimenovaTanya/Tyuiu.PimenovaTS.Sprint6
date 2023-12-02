
namespace Tyuiu.PimenovaTS.Sprint6.Task0.V10
{
    partial class FormMain_PTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_PTS));
            this.groupBoxCondition_PTS = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_PTS = new System.Windows.Forms.PictureBox();
            this.groupBoxEntrance_PTS = new System.Windows.Forms.GroupBox();
            this.groupBoxExit_PTS = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_PTS = new System.Windows.Forms.TextBox();
            this.textBoxResult_PTS = new System.Windows.Forms.TextBox();
            this.labelX_PTS = new System.Windows.Forms.Label();
            this.labelRes_PTS = new System.Windows.Forms.Label();
            this.buttonDone_PTS = new System.Windows.Forms.Button();
            this.buttonHelp_PTS = new System.Windows.Forms.Button();
            this.labelTask_PTS = new System.Windows.Forms.Label();
            this.groupBoxCondition_PTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PTS)).BeginInit();
            this.groupBoxEntrance_PTS.SuspendLayout();
            this.groupBoxExit_PTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PTS
            // 
            this.groupBoxCondition_PTS.Controls.Add(this.labelTask_PTS);
            this.groupBoxCondition_PTS.Controls.Add(this.pictureBoxFormula_PTS);
            this.groupBoxCondition_PTS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_PTS.Name = "groupBoxCondition_PTS";
            this.groupBoxCondition_PTS.Size = new System.Drawing.Size(776, 255);
            this.groupBoxCondition_PTS.TabIndex = 0;
            this.groupBoxCondition_PTS.TabStop = false;
            this.groupBoxCondition_PTS.Text = "Условие";
            // 
            // pictureBoxFormula_PTS
            // 
            this.pictureBoxFormula_PTS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_PTS.Image")));
            this.pictureBoxFormula_PTS.Location = new System.Drawing.Point(485, 22);
            this.pictureBoxFormula_PTS.Name = "pictureBoxFormula_PTS";
            this.pictureBoxFormula_PTS.Size = new System.Drawing.Size(285, 50);
            this.pictureBoxFormula_PTS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFormula_PTS.TabIndex = 1;
            this.pictureBoxFormula_PTS.TabStop = false;
            // 
            // groupBoxEntrance_PTS
            // 
            this.groupBoxEntrance_PTS.Controls.Add(this.labelX_PTS);
            this.groupBoxEntrance_PTS.Controls.Add(this.textBoxVarX_PTS);
            this.groupBoxEntrance_PTS.Location = new System.Drawing.Point(18, 274);
            this.groupBoxEntrance_PTS.Name = "groupBoxEntrance_PTS";
            this.groupBoxEntrance_PTS.Size = new System.Drawing.Size(433, 96);
            this.groupBoxEntrance_PTS.TabIndex = 1;
            this.groupBoxEntrance_PTS.TabStop = false;
            this.groupBoxEntrance_PTS.Text = "Вход данных:";
            // 
            // groupBoxExit_PTS
            // 
            this.groupBoxExit_PTS.Controls.Add(this.labelRes_PTS);
            this.groupBoxExit_PTS.Controls.Add(this.textBoxResult_PTS);
            this.groupBoxExit_PTS.Location = new System.Drawing.Point(471, 274);
            this.groupBoxExit_PTS.Name = "groupBoxExit_PTS";
            this.groupBoxExit_PTS.Size = new System.Drawing.Size(317, 96);
            this.groupBoxExit_PTS.TabIndex = 2;
            this.groupBoxExit_PTS.TabStop = false;
            this.groupBoxExit_PTS.Text = "Выход данных:";
            // 
            // textBoxVarX_PTS
            // 
            this.textBoxVarX_PTS.Location = new System.Drawing.Point(6, 49);
            this.textBoxVarX_PTS.Name = "textBoxVarX_PTS";
            this.textBoxVarX_PTS.Size = new System.Drawing.Size(118, 22);
            this.textBoxVarX_PTS.TabIndex = 0;
            this.textBoxVarX_PTS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_PTS_KeyPress);
            // 
            // textBoxResult_PTS
            // 
            this.textBoxResult_PTS.Location = new System.Drawing.Point(6, 49);
            this.textBoxResult_PTS.Name = "textBoxResult_PTS";
            this.textBoxResult_PTS.ReadOnly = true;
            this.textBoxResult_PTS.Size = new System.Drawing.Size(117, 22);
            this.textBoxResult_PTS.TabIndex = 0;
            // 
            // labelX_PTS
            // 
            this.labelX_PTS.AutoSize = true;
            this.labelX_PTS.Location = new System.Drawing.Point(14, 29);
            this.labelX_PTS.Name = "labelX_PTS";
            this.labelX_PTS.Size = new System.Drawing.Size(108, 17);
            this.labelX_PTS.TabIndex = 1;
            this.labelX_PTS.Text = "Переменная X:";
            // 
            // labelRes_PTS
            // 
            this.labelRes_PTS.AutoSize = true;
            this.labelRes_PTS.Location = new System.Drawing.Point(6, 29);
            this.labelRes_PTS.Name = "labelRes_PTS";
            this.labelRes_PTS.Size = new System.Drawing.Size(80, 17);
            this.labelRes_PTS.TabIndex = 1;
            this.labelRes_PTS.Text = "Результат:";
            // 
            // buttonDone_PTS
            // 
            this.buttonDone_PTS.Location = new System.Drawing.Point(686, 397);
            this.buttonDone_PTS.Name = "buttonDone_PTS";
            this.buttonDone_PTS.Size = new System.Drawing.Size(96, 41);
            this.buttonDone_PTS.TabIndex = 3;
            this.buttonDone_PTS.Text = "Выполнить";
            this.buttonDone_PTS.UseVisualStyleBackColor = true;
            this.buttonDone_PTS.Click += new System.EventHandler(this.buttonDone_PTS_Click);
            // 
            // buttonHelp_PTS
            // 
            this.buttonHelp_PTS.Location = new System.Drawing.Point(635, 397);
            this.buttonHelp_PTS.Name = "buttonHelp_PTS";
            this.buttonHelp_PTS.Size = new System.Drawing.Size(45, 41);
            this.buttonHelp_PTS.TabIndex = 3;
            this.buttonHelp_PTS.Text = "?";
            this.buttonHelp_PTS.UseVisualStyleBackColor = true;
            this.buttonHelp_PTS.Click += new System.EventHandler(this.buttonHelp_PTS_Click);
            // 
            // labelTask_PTS
            // 
            this.labelTask_PTS.AutoSize = true;
            this.labelTask_PTS.Location = new System.Drawing.Point(12, 22);
            this.labelTask_PTS.Name = "labelTask_PTS";
            this.labelTask_PTS.Size = new System.Drawing.Size(241, 17);
            this.labelTask_PTS.TabIndex = 2;
            this.labelTask_PTS.Text = "Вычислить выражение по формуле";
            // 
            // FormMain_PTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_PTS);
            this.Controls.Add(this.buttonDone_PTS);
            this.Controls.Add(this.groupBoxExit_PTS);
            this.Controls.Add(this.groupBoxEntrance_PTS);
            this.Controls.Add(this.groupBoxCondition_PTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_PTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 10 | Пименова Т. С.";
            this.groupBoxCondition_PTS.ResumeLayout(false);
            this.groupBoxCondition_PTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PTS)).EndInit();
            this.groupBoxEntrance_PTS.ResumeLayout(false);
            this.groupBoxEntrance_PTS.PerformLayout();
            this.groupBoxExit_PTS.ResumeLayout(false);
            this.groupBoxExit_PTS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PTS;
        private System.Windows.Forms.PictureBox pictureBoxFormula_PTS;
        private System.Windows.Forms.GroupBox groupBoxEntrance_PTS;
        private System.Windows.Forms.GroupBox groupBoxExit_PTS;
        private System.Windows.Forms.Label labelX_PTS;
        private System.Windows.Forms.TextBox textBoxVarX_PTS;
        private System.Windows.Forms.Label labelRes_PTS;
        private System.Windows.Forms.TextBox textBoxResult_PTS;
        private System.Windows.Forms.Button buttonDone_PTS;
        private System.Windows.Forms.Button buttonHelp_PTS;
        private System.Windows.Forms.Label labelTask_PTS;
    }
}

