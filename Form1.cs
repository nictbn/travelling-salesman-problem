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
        double[,] distancesMatrix;
        public Form1()
        {
            InitializeComponent();
            CrossoverDropDown.SelectedIndex = 0;
            MutationDropDown.SelectedIndex = 0;
        }

        private void LoadDatasetButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            LoadBenchmarkOpenFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "");
            if (LoadBenchmarkOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int numberOfCities = 0;
                    int currentMatrixLine = 0;
                    if ((myStream = LoadBenchmarkOpenFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(myStream);
                            string line;
                            while ((line = file.ReadLine()) != null)
                            {
                                line = line.Trim();
                                if (line.Length == 0 || line.StartsWith("#") || line.StartsWith("EOF"))
                                {
                                    continue;
                                }
                                string[] distances = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                                if (currentMatrixLine == 0)
                                {
                                    numberOfCities = distances.Length;
                                    distancesMatrix = new double[numberOfCities, numberOfCities];
                                }

                                if (distances.Length != numberOfCities)
                                {
                                    throw new Exception("Line " + currentMatrixLine + " does not have enough distances!");
                                }

                                for (int i = 0; i < numberOfCities; i++)
                                {
                                    double distance;
                                    bool result = double.TryParse(distances[i], out distance);
                                    if (!result)
                                    {
                                        throw new Exception("Could not convert distance " + distances[i] + " on row " + currentMatrixLine + " column " + i);
                                    }
                                    distancesMatrix[currentMatrixLine, i] = distance;
                                }
                                currentMatrixLine++;
                            }
                            if (currentMatrixLine != numberOfCities)
                            {
                                throw new Exception("The distances matrix is incomplete!");
                            }
                            ExecuteAlgorithmButton.Enabled = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured. " + ex.Message);
                    return;
                }
            }
        }
        private void ExecuteAlgorithmButton_Click(object sender, EventArgs e)
        {

        }
    }
}
