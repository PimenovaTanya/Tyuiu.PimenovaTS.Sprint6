
namespace Tyuiu.PimenovaTS.Sprint6.Task7.V18
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxMe_PTS = new System.Windows.Forms.PictureBox();
            this.labelMe_PTS = new System.Windows.Forms.Label();
            this.buttonOK_PTS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_PTS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMe_PTS
            // 
            this.pictureBoxMe_PTS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMe_PTS.Image")));
            this.pictureBoxMe_PTS.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxMe_PTS.Name = "pictureBoxMe_PTS";
            this.pictureBoxMe_PTS.Size = new System.Drawing.Size(191, 251);
            this.pictureBoxMe_PTS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMe_PTS.TabIndex = 0;
            this.pictureBoxMe_PTS.TabStop = false;
            // 
            // labelMe_PTS
            // 
            this.labelMe_PTS.AutoSize = true;
            this.labelMe_PTS.Location = new System.Drawing.Point(211, 13);
            this.labelMe_PTS.Name = "labelMe_PTS";
            this.labelMe_PTS.Size = new System.Drawing.Size(340, 170);
            this.labelMe_PTS.TabIndex = 1;
            this.labelMe_PTS.Text = resources.GetString("labelMe_PTS.Text");
            // 
            // buttonOK_PTS
            // 
            this.buttonOK_PTS.Location = new System.Drawing.Point(434, 229);
            this.buttonOK_PTS.Name = "buttonOK_PTS";
            this.buttonOK_PTS.Size = new System.Drawing.Size(112, 34);
            this.buttonOK_PTS.TabIndex = 2;
            this.buttonOK_PTS.Text = "OK";
            this.buttonOK_PTS.UseVisualStyleBackColor = true;
            this.buttonOK_PTS.Click += new System.EventHandler(this.buttonOK_PTS_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 276);
            this.Controls.Add(this.buttonOK_PTS);
            this.Controls.Add(this.labelMe_PTS);
            this.Controls.Add(this.pictureBoxMe_PTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_PTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMe_PTS;
        private System.Windows.Forms.Label labelMe_PTS;
        private System.Windows.Forms.Button buttonOK_PTS;
    }
}