﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GeniticExt.GA.Rules.Samples
{
    class OneGenInMutationRateMutationRule : MutationRule
    {
        public override void Mutation(Population population)
        {
            Random rnd = population.Rnd;
            foreach(Chromosome gen in population.Genotypes)
            {
                if (rnd.NextDouble() <= population.MutationRate)
                {
                    gen.Genes[rnd.Next(population.ChromosomeLenght)] = population.Problem.SearchArea.Min + rnd.NextDouble() * (population.Problem.SearchArea.Max - population.Problem.SearchArea.Min);
                }
            }
        }
    }
}
