using System;
using System.Collections.Generic;
using System.Text;

namespace TravellingSalesmanProblem
{
    public  class Individual
    {
        public int numberOfCities;
        public int[] chromosome;
        public double fitness;
        public Individual(int numberOfCities)
        {
            this.numberOfCities = numberOfCities;
            chromosome = new int[numberOfCities];
            fitness = 0;
        }
        public Individual(int numberOfCities, int[] chromosome)
        {
            this.numberOfCities = numberOfCities;
            this.chromosome = chromosome;
            fitness = 0;
        }

        internal void EvaluateIndividual(double[,] distancesMatrix)
        {
            fitness = 0;
            for (int i = 0; i < numberOfCities - 1; i++)
            {
                fitness += distancesMatrix[chromosome[i], chromosome[i + 1]];
            }
        }
    }

    public class IndividualComparer : IComparer<Individual>
    {
        public int Compare(Individual x, Individual y)
        {
            return (int)(x.fitness - y.fitness);
        }
    }
}
