using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZaripovEO.Sprint6.Task5.V26.Lib;

namespace Tyuiu.ZaripovEO.Sprint6.Task5.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\Users\zarip\source\repos\Tyuiu.ZaripovEO.Sprint6\Tyuiu.ZaripovEO.Sprint6.Task5.V26\bin\Debug\InPutFileTask5V26.txt";

        private void buttonDoIt_ZEO_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_ZEO.ColumnCount = 2;
            dataGridViewOutPut_ZEO.Columns[0].Width = 20;
            dataGridViewOutPut_ZEO.Columns[1].Width = 50;

            this.chartFunc_ZEO.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunc_ZEO.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunc_ZEO.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutPut_ZEO.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunc_ZEO.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_ZEO_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_ZEO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСТНб-23-1 \n Зарипов Егор Олегович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
