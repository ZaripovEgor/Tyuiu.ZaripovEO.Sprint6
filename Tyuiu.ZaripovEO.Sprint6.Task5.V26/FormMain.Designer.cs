
namespace Tyuiu.ZaripovEO.Sprint6.Task5.V26
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelp_ZEO = new System.Windows.Forms.Button();
            this.buttonOpen_ZEO = new System.Windows.Forms.Button();
            this.buttonDoIt_ZEO = new System.Windows.Forms.Button();
            this.groupBoxTask_ZEO = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZEO = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewOutPut_ZEO = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartFunc_ZEO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.groupBoxTask_ZEO.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_ZEO)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_ZEO)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp_ZEO);
            this.panel1.Controls.Add(this.buttonOpen_ZEO);
            this.panel1.Controls.Add(this.buttonDoIt_ZEO);
            this.panel1.Controls.Add(this.groupBoxTask_ZEO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 100);
            this.panel1.TabIndex = 0;
            // 
            // buttonHelp_ZEO
            // 
            this.buttonHelp_ZEO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ZEO.BackColor = System.Drawing.Color.LightYellow;
            this.buttonHelp_ZEO.Location = new System.Drawing.Point(588, 24);
            this.buttonHelp_ZEO.Name = "buttonHelp_ZEO";
            this.buttonHelp_ZEO.Size = new System.Drawing.Size(75, 64);
            this.buttonHelp_ZEO.TabIndex = 1;
            this.buttonHelp_ZEO.Text = "Справка";
            this.buttonHelp_ZEO.UseVisualStyleBackColor = false;
            this.buttonHelp_ZEO.Click += new System.EventHandler(this.buttonHelp_ZEO_Click);
            // 
            // buttonOpen_ZEO
            // 
            this.buttonOpen_ZEO.BackColor = System.Drawing.Color.LightCyan;
            this.buttonOpen_ZEO.Location = new System.Drawing.Point(507, 24);
            this.buttonOpen_ZEO.Name = "buttonOpen_ZEO";
            this.buttonOpen_ZEO.Size = new System.Drawing.Size(75, 64);
            this.buttonOpen_ZEO.TabIndex = 1;
            this.buttonOpen_ZEO.Text = "Открыть файл";
            this.buttonOpen_ZEO.UseVisualStyleBackColor = false;
            this.buttonOpen_ZEO.Click += new System.EventHandler(this.buttonOpen_ZEO_Click);
            // 
            // buttonDoIt_ZEO
            // 
            this.buttonDoIt_ZEO.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonDoIt_ZEO.Location = new System.Drawing.Point(426, 24);
            this.buttonDoIt_ZEO.Name = "buttonDoIt_ZEO";
            this.buttonDoIt_ZEO.Size = new System.Drawing.Size(75, 64);
            this.buttonDoIt_ZEO.TabIndex = 1;
            this.buttonDoIt_ZEO.Text = "Выполнить";
            this.buttonDoIt_ZEO.UseVisualStyleBackColor = false;
            this.buttonDoIt_ZEO.Click += new System.EventHandler(this.buttonDoIt_ZEO_Click);
            // 
            // groupBoxTask_ZEO
            // 
            this.groupBoxTask_ZEO.Controls.Add(this.textBoxTask_ZEO);
            this.groupBoxTask_ZEO.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_ZEO.Name = "groupBoxTask_ZEO";
            this.groupBoxTask_ZEO.Size = new System.Drawing.Size(407, 81);
            this.groupBoxTask_ZEO.TabIndex = 0;
            this.groupBoxTask_ZEO.TabStop = false;
            this.groupBoxTask_ZEO.Text = "Условие:";
            // 
            // textBoxTask_ZEO
            // 
            this.textBoxTask_ZEO.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_ZEO.Multiline = true;
            this.textBoxTask_ZEO.Name = "textBoxTask_ZEO";
            this.textBoxTask_ZEO.Size = new System.Drawing.Size(394, 55);
            this.textBoxTask_ZEO.TabIndex = 0;
            this.textBoxTask_ZEO.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridView\r\nположительн" +
    "ые значения и построить диаграму по этим значениям.\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewOutPut_ZEO);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 350);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewOutPut_ZEO
            // 
            this.dataGridViewOutPut_ZEO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_ZEO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_ZEO.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOutPut_ZEO.Name = "dataGridViewOutPut_ZEO";
            this.dataGridViewOutPut_ZEO.ReadOnly = true;
            this.dataGridViewOutPut_ZEO.Size = new System.Drawing.Size(194, 350);
            this.dataGridViewOutPut_ZEO.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartFunc_ZEO);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(194, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 350);
            this.panel3.TabIndex = 2;
            // 
            // chartFunc_ZEO
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunc_ZEO.ChartAreas.Add(chartArea1);
            this.chartFunc_ZEO.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunc_ZEO.Legends.Add(legend1);
            this.chartFunc_ZEO.Location = new System.Drawing.Point(0, 0);
            this.chartFunc_ZEO.Name = "chartFunc_ZEO";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunc_ZEO.Series.Add(series1);
            this.chartFunc_ZEO.Size = new System.Drawing.Size(499, 350);
            this.chartFunc_ZEO.TabIndex = 0;
            this.chartFunc_ZEO.Text = "chart1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(194, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 350);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(709, 489);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 26 | Зарипов Е. О. ";
            this.panel1.ResumeLayout(false);
            this.groupBoxTask_ZEO.ResumeLayout(false);
            this.groupBoxTask_ZEO.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_ZEO)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_ZEO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp_ZEO;
        private System.Windows.Forms.Button buttonOpen_ZEO;
        private System.Windows.Forms.Button buttonDoIt_ZEO;
        private System.Windows.Forms.GroupBox groupBoxTask_ZEO;
        private System.Windows.Forms.TextBox textBoxTask_ZEO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_ZEO;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_ZEO;
        private System.Windows.Forms.Splitter splitter1;
    }
}

