﻿using System.Collections.Generic;
using EstatisticaFatec.Models.VariavelQuantitativa;

namespace EstatisticaFatec.Models.VariavelContinua
{
    public class VariavelContinuaContainerEntity
    {
        public VariavelContinuaContainerEntity()
        {
            Rol = new List<int>();
            InputValue = new List<int>();
            VariavelContinuaEntity = new List<VariavelContinuaEntity>();
        }

        /// <summary>
        /// São os registros que foram obtidos pelo input [textarea]
        /// </summary>
        public List<int> InputValue { get; set; }

        /// <summary>
        /// Rol é a massa de dados ordenada de forma crescente
        /// </summary>
        public List<int> Rol { get; set; }

        /// <summary>
        /// É o valor mínimo dos inputs [xmin]
        /// </summary>
        public int MinLinha { get; set; }

        /// <summary>
        /// É o valor máximo dos inputs [xmax]
        /// </summary>
        public int MaxLinha { get; set; }

        /// <summary>
        /// É o valor máximo dos inputs [xmax] menos o valor minimo [xmin] - 1
        /// </summary>
        public int AL { get; set; }

        /// <summary>
        /// Indica a raiz quadrada da quantidade (count) do InputValue.
        /// No caso, os resultados aqui serão: K, K+1 e K-1
        /// </summary>
        public List<decimal> K { get; set; }

        /// <summary>
        /// AL (1ª Passo) / K (2ª Passo)
        /// Sendo o AL um numero divisível por algum K, caso não seja o AL é incrementado +1
        /// </summary>
        public decimal IC { get; set; }


        public List<VariavelContinuaEntity> VariavelContinuaEntity { get; set; }
    }
}