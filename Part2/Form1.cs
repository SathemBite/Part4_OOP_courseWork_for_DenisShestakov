using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView_mainTable.Rows[0].Cells[0].Value = 1;
        }

        private void dataGridView_mainTable_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridView mainTable = (DataGridView)sender;
            mainTable.Rows[mainTable.Rows.Count - 1].Cells[0].Value = mainTable.Rows.Count;
        }

        private void button_computeConfScores_Click(object sender, EventArgs e)
        {
            ConfigurationRater cR = new ConfigurationRater(dataGridView_mainTable);
            MessageBox.Show(cR.FindBestConfigurations());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ConfigurationRater(dataGridView_mainTable).LoadControlExample();
        }

        private void button_clearTable_Click(object sender, EventArgs e)
        {
            dataGridView_mainTable.Rows.Clear();
        }

        private void button_saveToFile_Click(object sender, EventArgs e)
        {
            new ConfigurationRater(dataGridView_mainTable).SaveToFile();
        }
    }
}
