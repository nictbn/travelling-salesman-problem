using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace TravellingSalesmanProblem
{
    class GeneticAlgorithm
    {
        public System.ComponentModel.DoWorkEventArgs e;
        public BackgroundWorker bw;
        int ORDER_ONE_CROSSOVER = 0;
        int PMX_CROSSOVER = 1;

        int INSERT_MUTATION = 0;
        int SWAP_MUTATION = 1;
        int INVERSION_MUTATION = 2;

        private int crossoverOperator;
        private int mutationOperator;
        private int numberOfGenerations;
        public int populationSize;
        private int recombinationProbability;
        private int mutationProbability;
        private double[,] distancesMatrix;
        private Random rng;
        private int numberOfCities;

        public GeneticAlgorithm(
            int crossoverOperator,
            int mutationOperator,
            int numberOfGenerations,
            int populationSize,
            int recombinationProbability,
            int mutationProbability,
            double[,] distancesMatrix)
        {
            this.crossoverOperator = crossoverOperator;
            this.mutationOperator = mutationOperator;
            this.numberOfGenerations = numberOfGenerations;
            this.populationSize = populationSize;
            this.distancesMatrix = distancesMatrix;
            this.recombinationProbability = recombinationProbability;
            this.mutationProbability = mutationProbability;
            numberOfCities = distancesMatrix.GetLength(0);
            rng = new Random();
        }

        internal List<Individual> RunAlgorithm()
        {
            List<Individual> population = CreateInitialPopulation();
            EvaluateAllIndividuals(population);
            for(int i = 0; i < numberOfGenerations; i++)
            {
                List<Individual> offspring = new List<Individual>();
                while (offspring.Count != populationSize)
                {
                    // pick two distinct parents
                    int firstContestant = rng.Next(populationSize);
                    int secondContestant = rng.Next(populationSize);
                    while (firstContestant == secondContestant)
                    {
                        secondContestant = rng.Next(populationSize);
                    }
                    int firstParent = PickParent(firstContestant, secondContestant, population);

                    firstContestant = rng.Next(populationSize);
                    secondContestant = rng.Next(populationSize);
                    while (firstContestant == secondContestant)
                    {
                        secondContestant = rng.Next(populationSize);
                    }
                    int secondParent = PickParent(firstContestant, secondContestant, population);

                    int recombinationRandom = rng.Next(100);
                    Individual firstOffspring = null;
                    Individual secondOffspring = null;
                    if (recombinationRandom < recombinationProbability)
                    {
                        if (crossoverOperator == ORDER_ONE_CROSSOVER)
                        {
                            firstOffspring = OrderOne(population[firstContestant], population[secondContestant]);
                            secondOffspring = OrderOne(population[secondContestant], population[firstContestant]);
                        }
                    }
                    else
                    {
                        firstOffspring = Copy(firstParent, population);
                        secondOffspring = Copy(secondParent, population);
                    }

                    int mutationRandom = rng.Next(100);
                    if (mutationRandom < mutationProbability)
                    {
                        if (mutationOperator == INSERT_MUTATION)
                        {
                            InsertMutation(firstOffspring);
                            InsertMutation(secondOffspring);
                        }
                        else if (mutationOperator == SWAP_MUTATION)
                        {
                            SwapMutation(firstOffspring);
                            SwapMutation(secondOffspring);
                        }
                        else if (mutationOperator == INVERSION_MUTATION)
                        {
                            InversionMutation(firstOffspring);
                            InversionMutation(secondOffspring);
                        }
                    }
                    CheckForDuplicates(firstOffspring);
                    CheckForDuplicates(secondOffspring);
                    offspring.Add(firstOffspring);
                    if (offspring.Count < populationSize)
                    {
                        offspring.Add(secondOffspring);
                    }
                }
                EvaluateAllIndividuals(offspring);
                population = offspring;
                bw.ReportProgress((i + 1) * 100 / numberOfGenerations);
            }
            bw.ReportProgress(100);
            population.Sort(new IndividualComparer());
            e.Result = population;
            return population;
        }

        private void CheckForDuplicates(Individual offspring)
        {
            List<int> alreadyTraversedCities = new List<int>();
            for (int i = 0; i < offspring.numberOfCities; i++)
            {
                if (alreadyTraversedCities.Contains(offspring.chromosome[i]))
                {
                    throw new Exception("Found duplicate cities in chromosome!!!");
                }
                alreadyTraversedCities.Add(offspring.chromosome[i]);
            }
        }

        private void InversionMutation(Individual offspring)
        {
            int firstPick = rng.Next(offspring.numberOfCities);
            int secondPick = rng.Next(offspring.numberOfCities);
            while (firstPick == secondPick)
            {
                secondPick = rng.Next(offspring.numberOfCities);
            }
            int t;
            if (firstPick > secondPick)
            {
                t = firstPick;
                firstPick = secondPick;
                secondPick = t;
            }
            List<int> inverseValues = new List<int>();
            for(int i = secondPick; i >= firstPick; i--)
            {
                inverseValues.Add(offspring.chromosome[i]);
            }
            int position = 0;
            for (int i = firstPick; i <= secondPick; i++)
            {
                offspring.chromosome[i] = inverseValues[position];
                position++;
            }

        }

        private void SwapMutation(Individual offspring)
        {
            int firstPick = rng.Next(offspring.numberOfCities);
            int secondPick = rng.Next(offspring.numberOfCities);
            while (firstPick == secondPick)
            {
                secondPick = rng.Next(offspring.numberOfCities);
            }
            int t;
            t = offspring.chromosome[firstPick];
            offspring.chromosome[firstPick] = offspring.chromosome[secondPick];
            offspring.chromosome[secondPick] = t;
        }

        private void InsertMutation(Individual offspring)
        {
            int firstPick = rng.Next(offspring.numberOfCities);
            int secondPick = rng.Next(offspring.numberOfCities);
            while(firstPick == secondPick)
            {
                secondPick = rng.Next(offspring.numberOfCities);
            }
            int t;
            if (firstPick > secondPick)
            {
                t = firstPick;
                firstPick = secondPick;
                secondPick = t;
            }
            int movedValue = offspring.chromosome[secondPick];
            for (int i = secondPick; i > firstPick + 1; i--)
            {
                offspring.chromosome[i] = offspring.chromosome[i - 1];
            }
            offspring.chromosome[firstPick + 1] = movedValue;
        }

        private Individual OrderOne(Individual individual1, Individual individual2)
        {
            Individual offspring = new Individual(individual1.numberOfCities);
            int firstCut = rng.Next(individual1.numberOfCities);
            int secondCut = rng.Next(individual1.numberOfCities);
            int t;
            if (firstCut > secondCut)
            {
                t = firstCut;
                firstCut = secondCut;
                secondCut = t;
            }
            List<int> alreadyPresentCities = new List<int>();
            for(int i = firstCut; i <= secondCut; i++)
            {
                offspring.chromosome[i] = individual1.chromosome[i];
                alreadyPresentCities.Add(individual1.chromosome[i]);
            }

            int currentPosition = secondCut;
            int copyPosition = secondCut;
            while (alreadyPresentCities.Count != offspring.numberOfCities)
            {
                currentPosition++;
                currentPosition = currentPosition % offspring.numberOfCities;
                if (alreadyPresentCities.Contains(individual2.chromosome[currentPosition]))
                {
                    continue;
                }
                copyPosition++;
                copyPosition = copyPosition % offspring.numberOfCities;
                offspring.chromosome[copyPosition] = individual2.chromosome[currentPosition];
                alreadyPresentCities.Add(individual2.chromosome[currentPosition]);
            }
            return offspring;
        }

        private Individual Copy(int ind, List<Individual> population)
        {
            Individual copy = new Individual(population[ind].numberOfCities);
            for (int i = 0; i < population[ind].numberOfCities; i++)
            {
                copy.chromosome[i] = population[ind].chromosome[i];
            }
            return copy;
        }

        private int PickParent(int firstContestant, int secondContestant, List<Individual> population)
        {
            if (population[firstContestant].fitness < population[secondContestant].fitness)
            {
                return firstContestant;
            }
            else
            {
                return secondContestant;
            }
        }

        private void EvaluateAllIndividuals(List<Individual> population)
        {
            for (int i = 0; i < population.Count; i++)
            {
                population[i].EvaluateIndividual(distancesMatrix);
            }
        }

        private List<Individual> CreateInitialPopulation()
        {
            List<Individual> population = new List<Individual>();
            for (int i = 0; i < populationSize; i++)
            {
                int[] randomChromosome = GenerateRandomChromosome();
                Individual individual = new Individual(numberOfCities, randomChromosome);
                population.Add(individual);
            }
            return population;
        }

        private int[] GenerateRandomChromosome()
        {
            int[] orderedChromosome = new int[numberOfCities];
            for (int i = 0; i < numberOfCities; i++)
            {
                orderedChromosome[i] = i;
            }
            int n = numberOfCities;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = orderedChromosome[k];
                orderedChromosome[k] = orderedChromosome[n];
                orderedChromosome[n] = value;
            }
            return orderedChromosome;
        }
    }
}
