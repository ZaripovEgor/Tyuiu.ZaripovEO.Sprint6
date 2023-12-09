using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZaripovEO.Sprint6.Task7.V6.Lib;
using System.IO;

namespace Tyuiu.ZaripovEO.Sprint6.Task7.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_ZEO.ColumnCount = 50;
            dataGridViewOutPut_ZEO.ColumnCount = 50;

            dataGridViewInPut_ZEO.RowCount = 50;
            dataGridViewOutPut_ZEO.RowCount = 50;
        }

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpen_ZEO_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ZEO.ShowDialog();
            openFilePath = openFileDialogTask_ZEO.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_ZEO.ColumnCount = columns;
            dataGridViewInPut_ZEO.RowCount = rows;
            dataGridViewOutPut_ZEO.RowCount = rows;
            dataGridViewOutPut_ZEO.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_ZEO.Columns[i].Width = 25;
                dataGridViewOutPut_ZEO.Columns[i].Width = 25;
            }
            
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_ZEO.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDoIt_ZEO.Enabled = true;
        }

        private void buttonDoIt_ZEO_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_ZEO.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_ZEO.Enabled = true;

        }

        private void buttonSave_ZEO_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_ZEO.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_ZEO.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_ZEO.ShowDialog();

            string path = saveFileDialogMatrix_ZEO.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            } 

            int rows = dataGridViewOutPut_ZEO.RowCount;
            int columns = dataGridViewOutPut_ZEO.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_ZEO.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_ZEO.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpen_ZEO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_ZEO.ToolTipTitle = "Открыть файл";
        }

        private void buttonDoIt_ZEO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_ZEO.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_ZEO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_ZEO.ToolTipTitle = "Сохраить в файл";
        }

        private void buttonHelp_ZEO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonHelp_ZEO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_ZEO.ToolTipTitle = "Справка";
        }

        private void buttonHelp_ZEO_Click_1(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
