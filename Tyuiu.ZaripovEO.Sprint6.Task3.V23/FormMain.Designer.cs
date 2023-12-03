
namespace Tyuiu.ZaripovEO.Sprint6.Task3.V23
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
            this.groupBoxMain_ZEO = new System.Windows.Forms.GroupBox();
            this.buttonHelp_ZEO = new System.Windows.Forms.Button();
            this.buttonDoIt_ZEO = new System.Windows.Forms.Button();
            this.dataGridViewOutPut_ZEO = new System.Windows.Forms.DataGridView();
            this.textBoxTask_ZEO = new System.Windows.Forms.TextBox();
            this.labelMtrx_ZEO = new System.Windows.Forms.Label();
            this.groupBoxMain_ZEO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_ZEO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMain_ZEO
            // 
            this.groupBoxMain_ZEO.Controls.Add(this.labelMtrx_ZEO);
            this.groupBoxMain_ZEO.Controls.Add(this.buttonHelp_ZEO);
            this.groupBoxMain_ZEO.Controls.Add(this.buttonDoIt_ZEO);
            this.groupBoxMain_ZEO.Controls.Add(this.dataGridViewOutPut_ZEO);
            this.groupBoxMain_ZEO.Controls.Add(this.textBoxTask_ZEO);
            this.groupBoxMain_ZEO.Location = new System.Drawing.Point(13, 13);
            this.groupBoxMain_ZEO.Name = "groupBoxMain_ZEO";
            this.groupBoxMain_ZEO.Size = new System.Drawing.Size(775, 298);
            this.groupBoxMain_ZEO.TabIndex = 0;
            this.groupBoxMain_ZEO.TabStop = false;
            this.groupBoxMain_ZEO.Text = "Условие";
            // 
            // buttonHelp_ZEO
            // 
            this.buttonHelp_ZEO.Location = new System.Drawing.Point(602, 256);
            this.buttonHelp_ZEO.Name = "buttonHelp_ZEO";
            this.buttonHelp_ZEO.Size = new System.Drawing.Size(39, 36);
            this.buttonHelp_ZEO.TabIndex = 2;
            this.buttonHelp_ZEO.Text = "?";
            this.buttonHelp_ZEO.UseVisualStyleBackColor = true;
            this.buttonHelp_ZEO.Click += new System.EventHandler(this.buttonHelp_ZEO_Click);
            // 
            // buttonDoIt_ZEO
            // 
            this.buttonDoIt_ZEO.Location = new System.Drawing.Point(670, 256);
            this.buttonDoIt_ZEO.Name = "buttonDoIt_ZEO";
            this.buttonDoIt_ZEO.Size = new System.Drawing.Size(99, 36);
            this.buttonDoIt_ZEO.TabIndex = 2;
            this.buttonDoIt_ZEO.Text = "Выполнить";
            this.buttonDoIt_ZEO.UseVisualStyleBackColor = true;
            this.buttonDoIt_ZEO.Click += new System.EventHandler(this.buttonDoIt_ZEO_Click);
            // 
            // dataGridViewOutPut_ZEO
            // 
            this.dataGridViewOutPut_ZEO.AllowUserToResizeColumns = false;
            this.dataGridViewOutPut_ZEO.AllowUserToResizeRows = false;
            this.dataGridViewOutPut_ZEO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_ZEO.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_ZEO.Location = new System.Drawing.Point(312, 19);
            this.dataGridViewOutPut_ZEO.Name = "dataGridViewOutPut_ZEO";
            this.dataGridViewOutPut_ZEO.ReadOnly = true;
            this.dataGridViewOutPut_ZEO.RowHeadersVisible = false;
            this.dataGridViewOutPut_ZEO.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewOutPut_ZEO.Size = new System.Drawing.Size(274, 273);
            this.dataGridViewOutPut_ZEO.TabIndex = 0;
            // 
            // textBoxTask_ZEO
            // 
            this.textBoxTask_ZEO.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_ZEO.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_ZEO.Multiline = true;
            this.textBoxTask_ZEO.Name = "textBoxTask_ZEO";
            this.textBoxTask_ZEO.ReadOnly = true;
            this.textBoxTask_ZEO.Size = new System.Drawing.Size(300, 273);
            this.textBoxTask_ZEO.TabIndex = 1;
            this.textBoxTask_ZEO.Text = resources.GetString("textBoxTask_ZEO.Text");
            // 
            // labelMtrx_ZEO
            // 
            this.labelMtrx_ZEO.AutoSize = true;
            this.labelMtrx_ZEO.Location = new System.Drawing.Point(309, 0);
            this.labelMtrx_ZEO.Name = "labelMtrx_ZEO";
            this.labelMtrx_ZEO.Size = new System.Drawing.Size(51, 13);
            this.labelMtrx_ZEO.TabIndex = 3;
            this.labelMtrx_ZEO.Text = "Матрица";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.groupBoxMain_ZEO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 23 | Зарипов Е. О.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxMain_ZEO.ResumeLayout(false);
            this.groupBoxMain_ZEO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_ZEO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain_ZEO;
        private System.Windows.Forms.Button buttonHelp_ZEO;
        private System.Windows.Forms.Button buttonDoIt_ZEO;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_ZEO;
        private System.Windows.Forms.TextBox textBoxTask_ZEO;
        private System.Windows.Forms.Label labelMtrx_ZEO;
    }
}

