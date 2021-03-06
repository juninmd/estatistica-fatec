﻿namespace EstatisticaFatec.Core.Models.VariavelContinua
{
    /// <summary>
    /// Classe responsável por listar os Itens da tabela
    /// -> Quantitativa
    /// </summary>
    public class VariavelContinuaEntity
    {
        /// <summary>
        /// [1] - Indice da classe [1][2][3][4]
        /// </summary>
        public decimal Classe { get; set; }

        /// <summary>
        /// [2] - Range de [x] para [y]
        /// </summary>
        public decimal[] Range { get; set; }

        /// <summary>
        /// [3] Contagens
        /// </summary>
        public decimal FI { get; set; }

        /// <summary>
        /// [4] - Porcentagem baseando na [quantidade total de FI] sobre o [FI]
        /// </summary>
        public decimal FEPorcent { get; set; }

        /// <summary>
        /// [5] - Números acumulativos sobre [FI]
        /// </summary>
        public decimal F { get; set; }

        /// <summary>
        /// [6] - Porcentagem acumulativa sobre [FE%]
        /// </summary>
        public decimal FPorcent { get; set; }

        /// <summary>
        /// [7] - Média do decimalervalo de classe
        /// </summary>
        public decimal XI { get; set; }

        /// <summary>
        /// [8] - Média - XI * FI
        /// </summary>
        public decimal XIFI { get; set; }
    }
}