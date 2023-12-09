
namespace Tyuiu.ZaripovEO.Sprint6.Task7.V6
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
            this.buttonHelp_ZEO = new System.Windows.Forms.Button();
            this.buttonSave_ZEO = new System.Windows.Forms.Button();
            this.buttonDoIt_ZEO = new System.Windows.Forms.Button();
            this.buttonOpen_ZEO = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxTask_ZEO = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZEO = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxInPut_ZEO = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_ZEO = new System.Windows.Forms.DataGridView();
            this.groupBoxOutPut_ZEO = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_ZEO = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_ZEO = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_ZEO = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_ZEO = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxTask_ZEO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxInPut_ZEO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_ZEO)).BeginInit();
            this.groupBoxOutPut_ZEO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_ZEO)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp_ZEO);
            this.panel1.Controls.Add(this.buttonSave_ZEO);
            this.panel1.Controls.Add(this.buttonDoIt_ZEO);
            this.panel1.Controls.Add(this.buttonOpen_ZEO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 79);
            this.panel1.TabIndex = 0;
            // 
            // buttonHelp_ZEO
            // 
            this.buttonHelp_ZEO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ZEO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_ZEO.Image = global::Tyuiu.ZaripovEO.Sprint6.Task7.V6.Properties.Resources.help;
            this.buttonHelp_ZEO.Location = new System.Drawing.Point(716, 4);
            this.buttonHelp_ZEO.Name = "buttonHelp_ZEO";
            this.buttonHelp_ZEO.Size = new System.Drawing.Size(97, 69);
            this.buttonHelp_ZEO.TabIndex = 0;
            this.buttonHelp_ZEO.UseVisualStyleBackColor = true;
            this.buttonHelp_ZEO.Click += new System.EventHandler(this.buttonHelp_ZEO_Click_1);
            // 
            // buttonSave_ZEO
            // 
            this.buttonSave_ZEO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_ZEO.Enabled = false;
            this.buttonSave_ZEO.Image = global::Tyuiu.ZaripovEO.Sprint6.Task7.V6.Properties.Resources.page_save;
            this.buttonSave_ZEO.Location = new System.Drawing.Point(210, 3);
            this.buttonSave_ZEO.Name = "buttonSave_ZEO";
            this.buttonSave_ZEO.Size = new System.Drawing.Size(97, 69);
            this.buttonSave_ZEO.TabIndex = 0;
            this.buttonSave_ZEO.UseVisualStyleBackColor = true;
            this.buttonSave_ZEO.Click += new System.EventHandler(this.buttonSave_ZEO_Click);
            // 
            // buttonDoIt_ZEO
            // 
            this.buttonDoIt_ZEO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDoIt_ZEO.Enabled = false;
            this.buttonDoIt_ZEO.Image = global::Tyuiu.ZaripovEO.Sprint6.Task7.V6.Properties.Resources.page_go;
            this.buttonDoIt_ZEO.Location = new System.Drawing.Point(107, 4);
            this.buttonDoIt_ZEO.Name = "buttonDoIt_ZEO";
            this.buttonDoIt_ZEO.Size = new System.Drawing.Size(97, 69);
            this.buttonDoIt_ZEO.TabIndex = 0;
            this.buttonDoIt_ZEO.UseVisualStyleBackColor = true;
            this.buttonDoIt_ZEO.Click += new System.EventHandler(this.buttonDoIt_ZEO_Click);
            // 
            // buttonOpen_ZEO
            // 
            this.buttonOpen_ZEO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen_ZEO.Image = global::Tyuiu.ZaripovEO.Sprint6.Task7.V6.Properties.Resources.folder_page;
            this.buttonOpen_ZEO.Location = new System.Drawing.Point(4, 4);
            this.buttonOpen_ZEO.Name = "buttonOpen_ZEO";
            this.buttonOpen_ZEO.Size = new System.Drawing.Size(97, 69);
            this.buttonOpen_ZEO.TabIndex = 0;
            this.buttonOpen_ZEO.UseVisualStyleBackColor = true;
            this.buttonOpen_ZEO.Click += new System.EventHandler(this.buttonOpen_ZEO_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxTask_ZEO);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 88);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxTask_ZEO
            // 
            this.groupBoxTask_ZEO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask_ZEO.Controls.Add(this.textBoxTask_ZEO);
            this.groupBoxTask_ZEO.Location = new System.Drawing.Point(4, 7);
            this.groupBoxTask_ZEO.Name = "groupBoxTask_ZEO";
            this.groupBoxTask_ZEO.Size = new System.Drawing.Size(800, 75);
            this.groupBoxTask_ZEO.TabIndex = 0;
            this.groupBoxTask_ZEO.TabStop = false;
            this.groupBoxTask_ZEO.Text = "Условие:";
            // 
            // textBoxTask_ZEO
            // 
            this.textBoxTask_ZEO.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_ZEO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_ZEO.Location = new System.Drawing.Point(9, 20);
            this.textBoxTask_ZEO.Multiline = true;
            this.textBoxTask_ZEO.Name = "textBoxTask_ZEO";
            this.textBoxTask_ZEO.Size = new System.Drawing.Size(785, 49);
            this.textBoxTask_ZEO.TabIndex = 0;
            this.textBoxTask_ZEO.Text = resources.GetString("textBoxTask_ZEO.Text");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 167);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxInPut_ZEO);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxOutPut_ZEO);
            this.splitContainer1.Size = new System.Drawing.Size(816, 244);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBoxInPut_ZEO
            // 
            this.groupBoxInPut_ZEO.Controls.Add(this.dataGridViewInPut_ZEO);
            this.groupBoxInPut_ZEO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_ZEO.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_ZEO.Name = "groupBoxInPut_ZEO";
            this.groupBoxInPut_ZEO.Size = new System.Drawing.Size(342, 244);
            this.groupBoxInPut_ZEO.TabIndex = 0;
            this.groupBoxInPut_ZEO.TabStop = false;
            this.groupBoxInPut_ZEO.Text = "Ввод:";
            // 
            // dataGridViewInPut_ZEO
            // 
            this.dataGridViewInPut_ZEO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_ZEO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_ZEO.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInPut_ZEO.Name = "dataGridViewInPut_ZEO";
            this.dataGridViewInPut_ZEO.Size = new System.Drawing.Size(336, 225);
            this.dataGridViewInPut_ZEO.TabIndex = 0;
            // 
            // groupBoxOutPut_ZEO
            // 
            this.groupBoxOutPut_ZEO.Controls.Add(this.dataGridViewOutPut_ZEO);
            this.groupBoxOutPut_ZEO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_ZEO.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_ZEO.Name = "groupBoxOutPut_ZEO";
            this.groupBoxOutPut_ZEO.Size = new System.Drawing.Size(470, 244);
            this.groupBoxOutPut_ZEO.TabIndex = 0;
            this.groupBoxOutPut_ZEO.TabStop = false;
            this.groupBoxOutPut_ZEO.Text = "Вывод:";
            // 
            // dataGridViewOutPut_ZEO
            // 
            this.dataGridViewOutPut_ZEO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_ZEO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_ZEO.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPut_ZEO.Name = "dataGridViewOutPut_ZEO";
            this.dataGridViewOutPut_ZEO.Size = new System.Drawing.Size(464, 225);
            this.dataGridViewOutPut_ZEO.TabIndex = 0;
            // 
            // openFileDialogTask_ZEO
            // 
            this.openFileDialogTask_ZEO.FileName = "openFileDialog1";
            // 
            // toolTipButton_ZEO
            // 
            this.toolTipButton_ZEO.AutoPopDelay = 5000;
            this.toolTipButton_ZEO.ForeColor = System.Drawing.Color.Khaki;
            this.toolTipButton_ZEO.InitialDelay = 300;
            this.toolTipButton_ZEO.IsBalloon = true;
            this.toolTipButton_ZEO.ReshowDelay = 100;
            this.toolTipButton_ZEO.ToolTipTitle = "Подсказда";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 411);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(832, 450);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 6 | Зарипов Е. О.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxTask_ZEO.ResumeLayout(false);
            this.groupBoxTask_ZEO.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxInPut_ZEO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_ZEO)).EndInit();
            this.groupBoxOutPut_ZEO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_ZEO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxTask_ZEO;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxInPut_ZEO;
        private System.Windows.Forms.GroupBox groupBoxOutPut_ZEO;
        private System.Windows.Forms.Button buttonHelp_ZEO;
        private System.Windows.Forms.Button buttonSave_ZEO;
        private System.Windows.Forms.Button buttonDoIt_ZEO;
        private System.Windows.Forms.Button buttonOpen_ZEO;
        private System.Windows.Forms.TextBox textBoxTask_ZEO;
        private System.Windows.Forms.DataGridView dataGridViewInPut_ZEO;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_ZEO;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_ZEO;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_ZEO;
        private System.Windows.Forms.ToolTip toolTipButton_ZEO;
    }
}

