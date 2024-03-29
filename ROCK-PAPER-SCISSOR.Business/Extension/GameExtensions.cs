﻿using ROCK_PAPER_SCISSOR.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCK_PAPER_SCISSOR.Business.Extension
{
    public static class GameExtensions
    {
        /// <summary>
        /// Validação da estrategia de Pedra-Papel-Tesoura
        /// </summary>
        /// <param name="strategy"></param>
        /// <returns></returns>
        public static bool ValidStrategy(string strategy)
        {
            return strategy.ToUpper() == "R" || strategy.ToUpper() == "P" || strategy.ToUpper() == "S";
        }

        /// <summary>
        /// Verifica qual é a estrategia vencedora do Pedra-Papel-Tesoura.
        /// </summary>
        /// <param name="strategy"></param>
        /// <param name="counter_strategy"></param>
        /// <returns></returns>
        public static bool StrategyWinsAgainst(this string strategy, string counter_strategy)
        {
            if (!ValidStrategy(counter_strategy))
                throw new NoSuchStrategyError();

            switch (strategy.ToUpper())
            {
                case "R":
                    return counter_strategy.ToUpper() == "S";

                case "P":
                    return counter_strategy.ToUpper() == "R";

                case "S":
                    return counter_strategy.ToUpper() == "P";

                default:
                    throw new NoSuchStrategyError();
            }
        }
    }
}
