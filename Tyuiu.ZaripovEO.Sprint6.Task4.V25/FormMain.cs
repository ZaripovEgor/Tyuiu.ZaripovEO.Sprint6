using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ZaripovEO.Sprint6.Task4.V25.Lib;

namespace Tyuiu.ZaripovEO.Sprint6.Task4.V25
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
                int startStep = Convert.ToInt32(textBoxStart_ZEO.Text);
                int stopStep = Convert.ToInt32(textBoxStop_ZEO.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunc_ZEO.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunc_ZEO.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutPut_ZEO.Text = "";

                chartFunc_ZEO.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunc_ZEO.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutPut_ZEO.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_ZEO_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxOutPut_ZEO.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\n Открыть его в блокноте", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //
        }

        private void chartFunc_ZEO_Click(object sender, EventArgs e)
        {
            //
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void buttonSave_ZEO_MouseEnter(object sender, EventArgs e)
        {
            //
        }

        private void buttonHelp_ZEO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИСТНб-23-1 \n Зарипов Егор Олегович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
