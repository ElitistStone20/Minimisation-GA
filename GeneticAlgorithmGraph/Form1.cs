using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace GeneticAlgorithmGraph
{
    public partial class Form1 : Form
    {
        private static int NumGenes;
        private static int PopulationSize;       
        private static double MutationProbability;
        private static int GenerationLimit;
        private static double MutationAlteration;       
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitliaseChart();     
        }
        private void InitliaseChart()
        {          
            //Making chart look nice
            GAChart.Series["Best Fitness"].Color = Color.Blue;
            GAChart.Series["Global Fitness"].Color = Color.Orange;
            GAChart.Series["Average Fitness"].Color = Color.Red;
            GAChart.ChartAreas[0].AxisX.Minimum = 0;         
        }     
        private void GeneticAlgoithm()
        {           
            InitialiseListBox();
            List<Individual> population = new List<Individual>();    
            //Create the initial population of blank individuals
            CreatePopulation(); 
            //Assign each gene in every individual's chromosome a random number between 0 and 1
            SeedPopulation();            
            //Initialise offspring list
            List<Individual> Offspring = new List<Individual>();
            //Initliase the global best to the first individual in the population
            Individual GlobalBest = population[0];
            //Loop until the generation limit is reached
            for (int gen = 0; gen < GenerationLimit; gen++)
            {
                //Initialise the local best individual for this generation
                Individual LocalBestIndividual = population[0];
                // Calculate the fitness of every individual within the population
                population = EvaluatePopulation(population);
                //Use Tournament selection or Roulette Wheel selection to select the best Parents to produce offspring
                Offspring = TournamentSelection(population);
                // Crossover and mutate the offspring individuals
                Offspring = CrossOverMutate(Offspring, gen);
                // Calculate the fitness of all offspring individuals and overright the population
                population = EvaluatePopulation(Offspring);   
                //Loop throught each individual of the population to find the best individual for this generation
                for (int i = 0; i < PopulationSize; i++)
                {                   
                    if (LocalBestIndividual.fitness > population[i].fitness)                    
                        LocalBestIndividual = population[i];                                                             
                }
                // Replace the worst individual within the population with the local best individual
                population = ReplaceWorstIndividual(Offspring, LocalBestIndividual);
                // Checxk if the local best individual is better than the global best individual
                if (GlobalBest.fitness > LocalBestIndividual.fitness)
                    GlobalBest = LocalBestIndividual;
                // Graph stuff
                GAChart.Series["Best Fitness"].Points.AddXY(gen, LocalBestIndividual.fitness);
                GAChart.Series["Global Fitness"].Points.AddXY(gen, GlobalBest.fitness);
                GAChart.Series["Average Fitness"].Points.AddXY(gen, AverageFitness(population));
                ListBoxResults.Items.Add($"Local Best: {LocalBestIndividual.fitness}");
                ListBoxResults.Items.Add($"Global Best: {GlobalBest.fitness}");
            }
            // Final output of the best individual throughout the run
            ListBoxResults.Items.Add($"Global Best fitness: {GlobalBest}");
            ListBoxResults.Items.Add($"Best Genes: {GlobalBest.GenesToString()}");
            return;
            List<Individual> ReplaceWorstIndividual(List<Individual> population, Individual LocalBest)
            {
                int WorstIndividualIndex = 0;
                int WorstFitness = population[0].fitness;
                for (int i = 0; i < population.Count; i++)
                {
                    if (population[i].fitness > WorstFitness)
                    {
                        WorstIndividualIndex = i;
                        WorstFitness = population[i].fitness;
                    }
                }
                population[WorstIndividualIndex] = LocalBest;
                return population;
            }
            void CreatePopulation()
            {
                for (int i = 0; i < PopulationSize; i++)
                    population.Add(new Individual($"{i}.0"));
            }
            void SeedPopulation()
            {
                Random rnd = new Random();              
                for (int i = 0; i < population.Count; i++)
                {
                    population[i].chromosome = new int[NumGenes];
                    for (int j = 0; j < NumGenes; j++)
                    {
                        int[] genes = new int[] { 0, 1 };
                        int gene = rnd.Next(0, genes.Length);
                        //double gene = rnd.CustomNextDouble(-32.0, 32.0);
                        population[i].chromosome[j] = gene;
                    }
                    population[i].SetFitness(Fitness(population[i]));
                }
            }          
            /*double Fitness(Individual individual)
            {          
                double sum1 = 0, sum2 = 0;
                foreach (double gene in individual.chromosome)
                {
                    sum1 += Math.Pow(gene, 2);
                    sum2 += Math.Cos(2 * Math.PI * gene);
                }              
                double rootSum1 = Math.Sqrt(sum1 / NumGenes);                                                     
                return (-20 * Math.Pow(Math.E, -0.2 * rootSum1)) - Math.Pow(Math.E, sum2 / NumGenes);               
            }*/
            List<Individual> EvaluatePopulation(List<Individual> population )
            {
                //Loop through every individual and calculate their fitness
                for (int i = 0; i < population.Count; i++)
                    population[i].SetFitness(Fitness(population[i]));
                return population;
            }

            /*double Fitness(Individual individual)
            {
                return 10 * NumGenes + CosX();
                double CosX()
                {
                    double output = 0;
                    for (int i = 0; i < NumGenes; i++)                  
                        output += Math.Pow(individual.chromosome[i], 2) - (10 * Math.Cos(2 * Math.PI * individual.chromosome[i]));
                    return output;
                }
            }*/
            int Fitness(Individual individual)
            {
                // Count all 1's within the indivdual's chromosome 
                int fitness = 0;
                for (int i = 0; i < NumGenes; i++)               
                    fitness += individual.chromosome[i];
                return fitness;
            }
        }
        /// <summary>
        /// Chooses a parent with the highest fitness and adds to the offspring list
        /// </summary>
        /// <param name="population"></param>
        /// <returns></returns>
        private static List<Individual> TournamentSelection(List<Individual> population)
        {
            Random rnd = new Random();
            List<Individual> parents = new List<Individual>();  
            // Loop through the population
            for (int i = 0; i < PopulationSize; i++)
            {
                // Select parents randomly from the population
                Individual parent1 = population[rnd.Next(0, population.Count)];
                Individual parent2 = population[rnd.Next(0, population.Count)];
                // Check which has the lowest fitness. Lowest fitness indivdual added to the parents list
                if (parent1.fitness < parent2.fitness)
                    parents.Add(parent1);
                else
                    parents.Add(parent2);
            }        
            return parents;                       
        }
        private static List<Individual> RouletteWheel(List<Individual> population)
        {
            Random rnd = new Random();
            List<Individual> parents = new List<Individual>();
            int TotalFitness = CalculateTotalFitness();
            for (int i = 0; i < population.Count; i++)
            {
                double selectionPoint = rnd.Next(0, TotalFitness);
                double Running_Total = 0;
                int index = 1;
                while (Running_Total >= selectionPoint && index < population.Count)
                {
                    if (population[i].fitness != 0)
                    {
                        Running_Total += population[index].fitness;
                        //Running_Total += 1.0 / population[index].fitness;
                        index++;
                    }                  
                }
                parents.Add(population[index - 1]);
            }
            return parents;
            int CalculateTotalFitness()
            {
                int fitness = 0;
                for (int i = 0; i < population.Count; i++)               
                    fitness += population[i].fitness;
                return fitness;               
            }
        }
        List<Individual> CrossOverMutate(List<Individual> Offspring, int generation)
        {
            Random rnd = new Random();
            // Loop through the offspring
            for (int i = 0; i < Offspring.Count-1; i += 2)
            {              
                //Loop through every gene of the individual
                for (int j = 0; j <= rnd.Next(0,NumGenes); j++)
                {
                    // Swap genes up to the randomly generated number between 0 and the number of genes (Crossover point)
                    int tempGene = Offspring[i].chromosome[j];
                    Offspring[i].setGene(j, Offspring[i+1].chromosome[j]);
                    Offspring[i+1].setGene(j, tempGene);
                }
                // Mutate both individuals (possibly)
                Offspring[i].setChromosome(Mutate(Offspring[i]));
                Offspring[i+1].setChromosome(Mutate(Offspring[i+1]));                  
            }
            return Offspring;
            /*double[] Mutate(Individual individual)
            {
                for (int i = 0; i < NumGenes; i++)
                {
                    if (rnd.NextDouble() < MutationProbability)
                    {
                        double bit_gene = individual.chromosome[i];
                        int[] signs = { -1, -1 };
                        int sign = signs[rnd.Next(0, signs.Length)];
                        bit_gene += sign * rnd.CustomNextDouble(0.0, MutationAlteration);
                        if (bit_gene < -32.0)
                            bit_gene = -32.0;
                        else if (bit_gene > 32.0)
                            bit_gene = 32.0;
                        individual.setGene(i, bit_gene);
                    }
                }
                return individual.chromosome;
            }*/
            int[] Mutate(Individual individual)
            {
                //Loop through all genes
                for (int i = 0; i < NumGenes; i++)
                {
                    // If randomly generated double between 0 and 1 is less than the Mutation probability then mutate
                    if (rnd.NextDouble() < MutationProbability)
                    {
                        // Flip bits
                        if (individual.chromosome[i] == 1)
                            individual.setGene(i, 0);
                        else
                            individual.setGene(i, 1);
                    }
                }
                return individual.chromosome;
            }
        }
        private int AverageFitness(List<Individual> population)
        {
            int average = 0;
            for (int i = 0; i < population.Count; i++)            
                average += population[i].fitness;
            average = average / PopulationSize;
            return average;
        }
        private void ExecuteGA_Click(object sender, EventArgs e)
        {            
            ListBoxResults.Items.Clear();
            foreach (System.Windows.Forms.DataVisualization.Charting.Series series in GAChart.Series)
                series.Points.Clear();
            if (ValidateVariables())
                GeneticAlgoithm();
            else
                MessageBox.Show("Error with one of the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            bool ValidateVariables()
            {
                if (int.TryParse(txtGenerations.Text, out GenerationLimit))
                    if (int.TryParse(txtPopulationSize.Text, out PopulationSize))
                        if (int.TryParse(txtNumGenes.Text, out NumGenes))                       
                            if (double.TryParse(txtMutAlteration.Text, out MutationAlteration))                          
                                if (double.TryParse(txtMutationProb.Text, out double mutationprob))
                                {
                                    MutationProbability = mutationprob;
                                    return true;
                                }                                                 
                return false;
            }
        }
        private void InitialiseListBox()
        {
            ListBoxResults.Items.Add($"Number Of Genes: {NumGenes}");
            ListBoxResults.Items.Add($"Population Size: {PopulationSize}");
            ListBoxResults.Items.Add($"Mutation Probability: {MutationProbability}");
            ListBoxResults.Items.Add($"Generation Limit: {GenerationLimit}");          
        }
    }
    public static class RandomExtends
    {
        public static double CustomNextDouble(this Random random, double minValue, double maxValue)
        {
            // Custom random function added on to Random class becaus edefault Random class does not contain a random double method between two values
            return Math.Round(random.NextDouble() * (maxValue - minValue) + minValue, 2);         
        }
    }
}
