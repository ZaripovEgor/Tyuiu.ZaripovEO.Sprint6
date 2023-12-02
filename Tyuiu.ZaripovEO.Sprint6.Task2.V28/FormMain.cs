using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZaripovEO.Sprint6.Task2.V28.Lib;

namespace Tyuiu.ZaripovEO.Sprint6.Task2.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDoIt_ZEO_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarStart_ZEO.Text);
                int stopStep = Convert.ToInt32(textBoxVarStop_ZEO.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.Titles.Add("График данной функции");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunc.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZEO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСТНб-23-1 \n Зарипов Егор Олегович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDoIt_ZEO_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDoIt_ZEO.BackColor = Color.Blue;
        }

        private void buttonDoIt_ZEO_MouseEnter(object sender, EventArgs e)
        {
            buttonDoIt_ZEO.BackColor = Color.Red;
        }

        private void buttonDoIt_ZEO_MouseLeave(object sender, EventArgs e)
        {
            buttonDoIt_ZEO.BackColor = Color.Green;
        }
    }
}
