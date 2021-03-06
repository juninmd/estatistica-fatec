﻿using System.Collections.Generic;
using EstatisticaFatec.Core;
using EstatisticaFatec.Core.Models;
using EstatisticaFatec.Core.VariavelDiscreta;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EstatisticaFatec.Tests
{
    [TestClass]
    public class VariavelQuantitativaTest
    {
        [TestMethod]
        public void Input()
        {

            var numeros = new BaseInputsEntity
            {
                InputValue = new List<decimal>
            {
               1000,
               2000,
               2000,
               5000,
               4000,
               4000,
               2000,
               3000,
               2000,
               3000,
               3000,
               3000,
               2000,
               3000,
               3000,
               3000,
               3000,
               1000,
               2000,
               3000
            }
            };


            var lista = new VariavelDiscretaApp().Build(numeros);
        }
    }
}
