using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZaripovEO.Sprint6.Task6.V26.Lib;
using System.IO;

namespace Tyuiu.ZaripovEO.Sprint6.Task6.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpen_ZEO_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ZEO.ShowDialog();
            openFilePath = openFileDialogTask_ZEO.FileName;
            textBoxInPut_ZEO.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_ZEO.Text = groupBoxOutPut_ZEO.Text + " " + openFileDialogTask_ZEO.FileName;
            buttonDoIt_ZEO.Enabled = true;
        }

        private void buttonDoIt_ZEO_Click(object sender, EventArgs e)
        {
            textBoxOutPut_ZEO.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_ZEO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void panelInPut_ZEO_Paint(object sender, PaintEventArgs e)
        {
            //
        }
    }
}
