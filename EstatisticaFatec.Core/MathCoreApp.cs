﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace EstatisticaFatec.Core
{
    public static class MathCoreApp
    {
        /// <summary>
        /// Funciona na Discreta
        /// </summary>
        /// <param name="rol"></param>
        /// <returns></returns>
        public static decimal Mediana(List<decimal> rol)
        {
            var meuArray = Rol(rol).ToArray();
            if (meuArray.Length % 2 == 0)
            {
                int posicaoA = (int)(meuArray.Length / 2) - 1;
                int posicaoB = (int)((meuArray.Length / 2));

                return (meuArray[posicaoA] + meuArray[posicaoB]) / 2;

            }
            else
            {
                return (meuArray.Length + 1) / 2;

            }
        }
        public static decimal[] Moda(List<decimal> inputData)
        {
            var maximo = (inputData.GroupBy(item => item).Select(g => g.Count())).Max();
            return (inputData.GroupBy(item => item).Where(g => g.Count() == maximo)).Select(q => q.Key).ToArray();
        }


        public static decimal MediaComum(List<decimal> inputData)
        {
            return Math.Round((decimal)inputData.Sum() / (decimal)inputData.Count, 2);
        }

        public static List<decimal> Rol(List<decimal> inputData)
        {
            return inputData.OrderBy(q => q).ToList();
        }

        public static decimal Quadrado(decimal input)
        {
            return Math.Round(input * input, 2);
        }

        /// <summary>
        /// (xi-`x)²
        /// </summary>
        /// <param name="inputData"></param>
        /// <param name="media"></param>
        /// <returns></returns>
        public static List<decimal> SomaTodosAoQuadrado(List<decimal> inputData, decimal media)
        {
            return inputData.Select(item => Quadrado(item - media)).ToList();
        }

        /// <summary>
        /// (input / valorbase) * 100
        /// </summary>
        /// <param name="input"></param>
        /// <param name="valorBase"></param>
        /// <returns></returns>
        public static decimal Porcentagem(decimal input, decimal valorBase)
        {
            return Math.Round((input / valorBase) * 100, 2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal RaizQuadrada(decimal input)
        {
            return (decimal)Math.Round(Math.Sqrt((double)input), 2);
        }



    }
}