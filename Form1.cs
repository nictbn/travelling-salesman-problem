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
        string benchmarkName;
        int numberOfGenerationsForDisplay;
        int populationSizeForDisplay;
        int recombinationProbabilityForDisplay;
        int mutationProbabilityForDisplay;
        string crossoverOperatorForDisplay;
        string mutationOperatorForDisplay;
        double[,] distancesMatrix;
        GeneticAlgorithm geneticAlgorithm;
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
                            StreamReader file = new StreamReader(myStream);
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
                            benchmarkName = LoadBenchmarkOpenFileDialog.SafeFileName;
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
            int numberOfGenerations;
            bool result = int.TryParse(NumberOfGenerationsTextBox.Text, out numberOfGenerations);
            if (!result)
            {
                MessageBox.Show("Could not parse the number of generations!");
                return;
            }
            if (numberOfGenerations < 1)
            {
                MessageBox.Show("The number of generations is incorrect. Try again!");
                return;
            }
            numberOfGenerationsForDisplay = numberOfGenerations;

            int populationSize;
            result = int.TryParse(PopulationSizeTextBox.Text, out populationSize);
            if (!result)
            {
                MessageBox.Show("Could not parse the population size!");
                return;
            }
            if (populationSize < 2)
            {
                MessageBox.Show("The population size is incorrect, it should have at least two individuals!");
                return;
            }
            populationSizeForDisplay = populationSize;

            int recombinationProbability;
            result = int.TryParse(RecombinationProbabilityTextBox.Text, out recombinationProbability);
            if (!result)
            {
                MessageBox.Show("Could not parse the recombination probability!");
                return;
            }
            if (recombinationProbability < 0 || recombinationProbability > 100)
            {
                MessageBox.Show("The recombination probability is incorrect!");
                return;
            }
            recombinationProbabilityForDisplay = recombinationProbability;


            int mutationProbability;
            result = int.TryParse(MutationProbabilityTextBox.Text, out mutationProbability);
            if (!result)
            {
                MessageBox.Show("Could not parse the mutation probability!");
                return;
            }
            if (mutationProbability < 0 || mutationProbability > 100)
            {
                MessageBox.Show("The mutation probability is incorrect!");
                return;
            }
            mutationProbabilityForDisplay = mutationProbability;

            int crossoverOperator = CrossoverDropDown.SelectedIndex;
            crossoverOperatorForDisplay = CrossoverDropDown.Items[crossoverOperator].ToString();
            int mutationOperator = MutationDropDown.SelectedIndex;
            mutationOperatorForDisplay = MutationDropDown.Items[mutationOperator].ToString();
            geneticAlgorithm = new GeneticAlgorithm(
                crossoverOperator,
                mutationOperator,
                numberOfGenerations,
                populationSize,
                recombinationProbability,
                mutationProbability,
                distancesMatrix);
            AlgorithmBackgroundWorker.RunWorkerAsync();
        }

        private void AlgorithmBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            geneticAlgorithm.e = e;
            geneticAlgorithm.bw = AlgorithmBackgroundWorker;
            geneticAlgorithm.RunAlgorithm();
        }

        private void AlgorithmBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<Individual> results = (List<Individual>)e.Result;
            GenerateFile(results);
            int a = 5;
        }

        private void GenerateFile(List<Individual> results)
        {
            using (StreamWriter writer = new StreamWriter("result" +
                "_R_" + recombinationProbabilityForDisplay +
                "_M_" + mutationProbabilityForDisplay +
                "_P_" + populationSizeForDisplay +
                "_MAX_GEN_" + numberOfGenerationsForDisplay + "_" + crossoverOperatorForDisplay + "_" + mutationOperatorForDisplay + ".txt"))
            {
                writer.WriteLine("Recombination Probability: " + recombinationProbabilityForDisplay);
                writer.WriteLine("Mutation Probability: " + mutationProbabilityForDisplay);
                writer.WriteLine("Population Size: " + populationSizeForDisplay);
                writer.WriteLine("Maximum Number Of Generations: " + numberOfGenerationsForDisplay);
                writer.WriteLine("Crossover Operator: " + crossoverOperatorForDisplay);
                writer.WriteLine("Mutation Operator: " + mutationOperatorForDisplay);
                for (int i = 0; i < results.Count; i++)
                {
                    writer.Write(i + ". Fitness: " + results[i].fitness);
                    writer.Write(i + " Chromosome: ");
                    for (int j = 0; j < results[i].numberOfCities; j++)
                    {
                        writer.Write(results[i].chromosome[j] + " ");
                    }
                    writer.WriteLine();
                }
            }
        }

        private void AlgorithmBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
