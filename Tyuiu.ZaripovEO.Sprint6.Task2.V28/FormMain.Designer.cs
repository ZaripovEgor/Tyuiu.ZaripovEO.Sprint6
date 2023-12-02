
namespace Tyuiu.ZaripovEO.Sprint6.Task2.V28
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
            this.groupBoxTask_ZEO = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_ZEO = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_ZEO = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZEO = new System.Windows.Forms.TextBox();
            this.buttonHelp_ZEO = new System.Windows.Forms.Button();
            this.buttonDoIt_ZEO = new System.Windows.Forms.Button();
            this.textBoxVarStart_ZEO = new System.Windows.Forms.TextBox();
            this.textBoxVarStop_ZEO = new System.Windows.Forms.TextBox();
            this.labelVarStart_ZEO = new System.Windows.Forms.Label();
            this.labelVarStop_ZEO = new System.Windows.Forms.Label();
            this.dataGridViewFunc = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_ZEO.SuspendLayout();
            this.groupBoxInPut_ZEO.SuspendLayout();
            this.groupBoxOutPut_ZEO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_ZEO
            // 
            this.groupBoxTask_ZEO.Controls.Add(this.textBoxTask_ZEO);
            this.groupBoxTask_ZEO.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_ZEO.Name = "groupBoxTask_ZEO";
            this.groupBoxTask_ZEO.Size = new System.Drawing.Size(456, 327);
            this.groupBoxTask_ZEO.TabIndex = 0;
            this.groupBoxTask_ZEO.TabStop = false;
            this.groupBoxTask_ZEO.Text = "Условие";
            // 
            // groupBoxInPut_ZEO
            // 
            this.groupBoxInPut_ZEO.Controls.Add(this.labelVarStop_ZEO);
            this.groupBoxInPut_ZEO.Controls.Add(this.labelVarStart_ZEO);
            this.groupBoxInPut_ZEO.Controls.Add(this.textBoxVarStop_ZEO);
            this.groupBoxInPut_ZEO.Controls.Add(this.textBoxVarStart_ZEO);
            this.groupBoxInPut_ZEO.Location = new System.Drawing.Point(13, 346);
            this.groupBoxInPut_ZEO.Name = "groupBoxInPut_ZEO";
            this.groupBoxInPut_ZEO.Size = new System.Drawing.Size(262, 72);
            this.groupBoxInPut_ZEO.TabIndex = 1;
            this.groupBoxInPut_ZEO.TabStop = false;
            this.groupBoxInPut_ZEO.Text = "Ввод данных";
            // 
            // groupBoxOutPut_ZEO
            // 
            this.groupBoxOutPut_ZEO.Controls.Add(this.chartFunction);
            this.groupBoxOutPut_ZEO.Controls.Add(this.dataGridViewFunc);
            this.groupBoxOutPut_ZEO.Location = new System.Drawing.Point(488, 13);
            this.groupBoxOutPut_ZEO.Name = "groupBoxOutPut_ZEO";
            this.groupBoxOutPut_ZEO.Size = new System.Drawing.Size(450, 405);
            this.groupBoxOutPut_ZEO.TabIndex = 2;
            this.groupBoxOutPut_ZEO.TabStop = false;
            this.groupBoxOutPut_ZEO.Text = "Вывод данных";
            // 
            // textBoxTask_ZEO
            // 
            this.textBoxTask_ZEO.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_ZEO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_ZEO.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_ZEO.Multiline = true;
            this.textBoxTask_ZEO.Name = "textBoxTask_ZEO";
            this.textBoxTask_ZEO.ReadOnly = true;
            this.textBoxTask_ZEO.Size = new System.Drawing.Size(379, 223);
            this.textBoxTask_ZEO.TabIndex = 0;
            this.textBoxTask_ZEO.Text = "Протабулировать функцию на заданном диапазоне.                         Результат " +
    "вывести в DataGridView и построить график функции.";
            // 
            // buttonHelp_ZEO
            // 
            this.buttonHelp_ZEO.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_ZEO.Location = new System.Drawing.Point(281, 353);
            this.buttonHelp_ZEO.Name = "buttonHelp_ZEO";
            this.buttonHelp_ZEO.Size = new System.Drawing.Size(75, 65);
            this.buttonHelp_ZEO.TabIndex = 3;
            this.buttonHelp_ZEO.Text = "Справка";
            this.buttonHelp_ZEO.UseVisualStyleBackColor = false;
            this.buttonHelp_ZEO.Click += new System.EventHandler(this.buttonHelp_ZEO_Click);
            // 
            // buttonDoIt_ZEO
            // 
            this.buttonDoIt_ZEO.BackColor = System.Drawing.Color.Green;
            this.buttonDoIt_ZEO.Location = new System.Drawing.Point(362, 354);
            this.buttonDoIt_ZEO.Name = "buttonDoIt_ZEO";
            this.buttonDoIt_ZEO.Size = new System.Drawing.Size(107, 64);
            this.buttonDoIt_ZEO.TabIndex = 3;
            this.buttonDoIt_ZEO.Text = "Выполнить";
            this.buttonDoIt_ZEO.UseVisualStyleBackColor = false;
            this.buttonDoIt_ZEO.Click += new System.EventHandler(this.buttonDoIt_ZEO_Click);
            // 
            // textBoxVarStart_ZEO
            // 
            this.textBoxVarStart_ZEO.Location = new System.Drawing.Point(7, 40);
            this.textBoxVarStart_ZEO.Name = "textBoxVarStart_ZEO";
            this.textBoxVarStart_ZEO.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarStart_ZEO.TabIndex = 0;
            // 
            // textBoxVarStop_ZEO
            // 
            this.textBoxVarStop_ZEO.Location = new System.Drawing.Point(156, 40);
            this.textBoxVarStop_ZEO.Name = "textBoxVarStop_ZEO";
            this.textBoxVarStop_ZEO.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarStop_ZEO.TabIndex = 0;
            // 
            // labelVarStart_ZEO
            // 
            this.labelVarStart_ZEO.AutoSize = true;
            this.labelVarStart_ZEO.Location = new System.Drawing.Point(7, 20);
            this.labelVarStart_ZEO.Name = "labelVarStart_ZEO";
            this.labelVarStart_ZEO.Size = new System.Drawing.Size(67, 13);
            this.labelVarStart_ZEO.TabIndex = 1;
            this.labelVarStart_ZEO.Text = "Старт шага:";
            // 
            // labelVarStop_ZEO
            // 
            this.labelVarStop_ZEO.AutoSize = true;
            this.labelVarStop_ZEO.Location = new System.Drawing.Point(153, 20);
            this.labelVarStop_ZEO.Name = "labelVarStop_ZEO";
            this.labelVarStop_ZEO.Size = new System.Drawing.Size(69, 13);
            this.labelVarStop_ZEO.TabIndex = 1;
            this.labelVarStop_ZEO.Text = "Конец шага:";
            // 
            // dataGridViewFunc
            // 
            this.dataGridViewFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F_X});
            this.dataGridViewFunc.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewFunc.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewFunc.Name = "dataGridViewFunc";
            this.dataGridViewFunc.RowHeadersVisible = false;
            this.dataGridViewFunc.Size = new System.Drawing.Size(107, 373);
            this.dataGridViewFunc.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // F_X
            // 
            this.F_X.HeaderText = "F(X)";
            this.F_X.Name = "F_X";
            this.F_X.Width = 50;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction.Legends.Add(legend1);
            this.chartFunction.Location = new System.Drawing.Point(120, 19);
            this.chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction.Series.Add(series1);
            this.chartFunction.Size = new System.Drawing.Size(324, 373);
            this.chartFunction.TabIndex = 1;
            this.chartFunction.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 426);
            this.Controls.Add(this.buttonDoIt_ZEO);
            this.Controls.Add(this.buttonHelp_ZEO);
            this.Controls.Add(this.groupBoxOutPut_ZEO);
            this.Controls.Add(this.groupBoxInPut_ZEO);
            this.Controls.Add(this.groupBoxTask_ZEO);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 28 | Зарипов Е. О.";
            this.groupBoxTask_ZEO.ResumeLayout(false);
            this.groupBoxTask_ZEO.PerformLayout();
            this.groupBoxInPut_ZEO.ResumeLayout(false);
            this.groupBoxInPut_ZEO.PerformLayout();
            this.groupBoxOutPut_ZEO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ZEO;
        private System.Windows.Forms.GroupBox groupBoxInPut_ZEO;
        private System.Windows.Forms.GroupBox groupBoxOutPut_ZEO;
        private System.Windows.Forms.TextBox textBoxTask_ZEO;
        private System.Windows.Forms.Label labelVarStop_ZEO;
        private System.Windows.Forms.Label labelVarStart_ZEO;
        private System.Windows.Forms.TextBox textBoxVarStop_ZEO;
        private System.Windows.Forms.TextBox textBoxVarStart_ZEO;
        private System.Windows.Forms.Button buttonHelp_ZEO;
        private System.Windows.Forms.Button buttonDoIt_ZEO;
        private System.Windows.Forms.DataGridView dataGridViewFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_X;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}

