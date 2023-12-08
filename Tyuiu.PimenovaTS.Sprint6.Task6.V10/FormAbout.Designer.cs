
namespace Tyuiu.PimenovaTS.Sprint6.Task6.V10
{
    partial class FormAboutProgram_PTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutProgram_PTS));
            this.pictureBoxMe_PTS = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose_PTS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_PTS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMe_PTS
            // 
            this.pictureBoxMe_PTS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMe_PTS.Image")));
            this.pictureBoxMe_PTS.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMe_PTS.Name = "pictureBoxMe_PTS";
            this.pictureBoxMe_PTS.Size = new System.Drawing.Size(177, 201);
            this.pictureBoxMe_PTS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMe_PTS.TabIndex = 0;
            this.pictureBoxMe_PTS.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 153);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonClose_PTS
            // 
            this.buttonClose_PTS.Location = new System.Drawing.Point(408, 183);
            this.buttonClose_PTS.Name = "buttonClose_PTS";
            this.buttonClose_PTS.Size = new System.Drawing.Size(113, 30);
            this.buttonClose_PTS.TabIndex = 2;
            this.buttonClose_PTS.Text = "OK";
            this.buttonClose_PTS.UseVisualStyleBackColor = true;
            this.buttonClose_PTS.Click += new System.EventHandler(this.buttonClose_PTS_Click);
            // 
            // FormAboutProgram_PTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 225);
            this.Controls.Add(this.buttonClose_PTS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxMe_PTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAboutProgram_PTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_PTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMe_PTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose_PTS;
    }
}