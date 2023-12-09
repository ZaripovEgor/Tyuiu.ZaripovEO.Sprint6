
namespace Tyuiu.ZaripovEO.Sprint6.Task7.V6
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
            this.buttonOk_ZEO = new System.Windows.Forms.Button();
            this.pictureBox_ZEO = new System.Windows.Forms.PictureBox();
            this.labelInfo_ZEO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ZEO)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk_ZEO
            // 
            this.buttonOk_ZEO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk_ZEO.Location = new System.Drawing.Point(411, 146);
            this.buttonOk_ZEO.Name = "buttonOk_ZEO";
            this.buttonOk_ZEO.Size = new System.Drawing.Size(105, 30);
            this.buttonOk_ZEO.TabIndex = 0;
            this.buttonOk_ZEO.Text = "Ok";
            this.buttonOk_ZEO.UseVisualStyleBackColor = true;
            this.buttonOk_ZEO.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_ZEO
            // 
            this.pictureBox_ZEO.Image = global::Tyuiu.ZaripovEO.Sprint6.Task7.V6.Properties.Resources.photo_2023_12_09_16_28_18;
            this.pictureBox_ZEO.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_ZEO.Name = "pictureBox_ZEO";
            this.pictureBox_ZEO.Size = new System.Drawing.Size(133, 164);
            this.pictureBox_ZEO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ZEO.TabIndex = 1;
            this.pictureBox_ZEO.TabStop = false;
            // 
            // labelInfo_ZEO
            // 
            this.labelInfo_ZEO.AutoSize = true;
            this.labelInfo_ZEO.Location = new System.Drawing.Point(152, 13);
            this.labelInfo_ZEO.Name = "labelInfo_ZEO";
            this.labelInfo_ZEO.Size = new System.Drawing.Size(284, 130);
            this.labelInfo_ZEO.TabIndex = 2;
            this.labelInfo_ZEO.Text = resources.GetString("labelInfo_ZEO.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 188);
            this.Controls.Add(this.labelInfo_ZEO);
            this.Controls.Add(this.pictureBox_ZEO);
            this.Controls.Add(this.buttonOk_ZEO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ZEO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk_ZEO;
        private System.Windows.Forms.PictureBox pictureBox_ZEO;
        private System.Windows.Forms.Label labelInfo_ZEO;
    }
}