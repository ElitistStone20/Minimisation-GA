using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmGraph
{
    public class Individual
    {
        public string ID;
        public int[] chromosome;
        public int fitness;
        public Individual(string IDNumber) { ID = IDNumber; }
        /// <summary>
        /// Outputs the genes of the current instance of this class as a string
        /// </summary>
        /// <returns></returns>
        public string GenesToString()
        {
            string output = null;
            for (int i = 0; i < chromosome.Length; i++)
                output += $"   {chromosome[i]}";
            return output;
        }
        public void SetFitness(int fitness)
        {
            this.fitness = fitness;
        }
        public void setGene(int index, int gene)
        {
            chromosome[index] = gene;
        }
        public void setChromosome(int[] chromosome)
        {
            this.chromosome = chromosome;
        }
    }
}
