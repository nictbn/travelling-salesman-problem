using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TravellingSalesmanProblem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CrossoverDropDown.SelectedIndex = 0;
            MutationDropDown.SelectedIndex = 0;
        }

        private void LoadDatasetButton_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            LoadBenchmarkOpenFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "");
            if (LoadBenchmarkOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = LoadBenchmarkOpenFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        private void ExecuteAlgorithmButton_Click(object sender, EventArgs e)
        {

        }
    }
}
