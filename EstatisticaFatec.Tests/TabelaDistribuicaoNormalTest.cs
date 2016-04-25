﻿using System;
using System.Collections.Generic;
using EstatisticaFatec.Core;
using EstatisticaFatec.Core.Const;
using EstatisticaFatec.Core.Models.DistribuicaoNormal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EstatisticaFatec.Tests
{
    [TestClass]
    public class TabelaDistribuicaoNormalTest
    {
        private TabelaDistribuicao TabelaDistribuicao => new TabelaDistribuicao();

        public Tuple<decimal, decimal> Add(double a, double b)
        {
            return new Tuple<decimal, decimal>(decimal.Parse(a.ToString()), decimal.Parse(b.ToString()));
        }

        [TestMethod]
        public void ValidandoTabela()
        {
            var lista = new List<Tuple<decimal, decimal>>
            {
                Add(0, 0.0000),
                Add(0.01, 0.0040),
                Add(0.02, 0.0080),
                Add(0.03, 0.0120),
                Add(0.04, 0.0160),
                Add(0.05, 0.0199),
                Add(0.06, 0.0239),
                Add(0.07, 0.0279),
                Add(0.08, 0.0319),
                Add(0.09, 0.0359),

                Add(0.10, 0.0398),
                Add(0.11, 0.0438),
                Add(0.12, 0.0478),
                Add(0.13, 0.0517),
                Add(0.14, 0.0557),
                Add(0.15, 0.0596),
                Add(0.16, 0.0636),
                Add(0.17, 0.0675),
                Add(0.18, 0.0714),
                Add(0.19, 0.0753),

                Add(0.20, 0.0793),
                Add(0.21, 0.0832),
                Add(0.22, 0.0871),
                Add(0.23, 0.0910),
                Add(0.24, 0.0948),
                Add(0.25, 0.0987),
                Add(0.26, 0.1026),
                Add(0.27, 0.1064),
                Add(0.28, 0.1103),
                Add(0.29, 0.1141),

                Add(0.30, 0.1179),
                Add(0.31, 0.1217),
                Add(0.32, 0.1255),
                Add(0.33, 0.1293),
                Add(0.34, 0.1331),
                Add(0.35, 0.1368),
                Add(0.36, 0.1406),
                Add(0.37, 0.1443),
                Add(0.38, 0.1480),
                Add(0.39, 0.1517),

                Add(0.40, 0.1554),
                Add(0.41, 0.1591),
                Add(0.42, 0.1628),
                Add(0.43, 0.1664),
                Add(0.44, 0.1700),
                Add(0.45, 0.1736),
                Add(0.46, 0.1772),
                Add(0.47, 0.1808),
                Add(0.48, 0.1844),
                Add(0.49, 0.1879),

                Add(0.50, 0.1915),
                Add(0.51, 0.1950),
                Add(0.52, 0.1985),
                Add(0.53, 0.2019),
                Add(0.54, 0.2054),
                Add(0.55, 0.2088),
                Add(0.56, 0.2123),
                Add(0.57, 0.2157),
                Add(0.58, 0.2190),
                Add(0.59, 0.2224),

                Add(0.60, 0.2257),
                Add(0.61, 0.2291),
                Add(0.62, 0.2324),
                Add(0.63, 0.2357),
                Add(0.64, 0.2389),
                Add(0.65, 0.2422),
                Add(0.66, 0.2454),
                Add(0.67, 0.2486),
                Add(0.68, 0.2517),
                Add(0.69, 0.2549),

                Add(0.70, 0.2580),
                Add(0.71, 0.2611),
                Add(0.72, 0.2642),
                Add(0.73, 0.2673),
                Add(0.74, 0.2704),
                Add(0.75, 0.2734),
                Add(0.76, 0.2764),
                Add(0.77, 0.2794), 
                Add(0.78, 0.2823),
                Add(0.79, 0.2852),


                Add(0.80, 0.2881),
                Add(0.81, 0.2910),
                Add(0.82, 0.2939),
                Add(0.83, 0.2967),
                Add(0.84, 0.2995),
                Add(0.85, 0.3023),
                Add(0.86, 0.3051),
                Add(0.87, 0.3078),
                Add(0.88, 0.3106),
                Add(0.89, 0.3133),

                Add(0.90, 0.3159),
                Add(0.91, 0.3186),
                Add(0.92, 0.3212),
                Add(0.93, 0.3238),
                Add(0.94, 0.3264),
                Add(0.95, 0.3289),
                Add(0.96, 0.3315),
                Add(0.97, 0.3340),
                Add(0.98, 0.3365),
                Add(0.99, 0.3389),

                Add(1.00, 0.3413),
                Add(1.01, 0.3438),
                Add(1.02, 0.3461),
                Add(1.03, 0.3485),
                Add(1.04, 0.3508),
                Add(1.05, 0.3531),
                Add(1.06, 0.3554),
                Add(1.07, 0.3577),
                Add(1.08, 0.3599),
                Add(1.09, 0.3621),

                Add(1.10, 0.3643),
                Add(1.11, 0.3665),
                Add(1.12, 0.3686),
                Add(1.13, 0.3708),
                Add(1.14, 0.3729),
                Add(1.15, 0.3749),
                Add(1.16, 0.3770),
                Add(1.17, 0.3790),
                Add(1.18, 0.3810),
                Add(1.19, 0.3830),

                Add(1.20, 0.3849),
                Add(1.21, 0.3869),
                Add(1.22, 0.3888),
                Add(1.23, 0.3907),
                Add(1.24, 0.3925),
                Add(1.25, 0.3944),
                Add(1.26, 0.3962),
                Add(1.27, 0.3980),
                Add(1.28, 0.3997),
                Add(1.29, 0.4015),

                Add(1.30, 0.4032),
                Add(1.31, 0.4049),
                Add(1.32, 0.4066),
                Add(1.33, 0.4082),
                Add(1.34, 0.4099),
                Add(1.35, 0.4115),
                Add(1.36, 0.4131),
                Add(1.37, 0.4147),
                Add(1.38, 0.4162),
                Add(1.39, 0.4177),

                Add(1.40, 0.4192),
                Add(1.41, 0.4207),
                Add(1.42, 0.4222),
                Add(1.43, 0.4236),
                Add(1.44, 0.4251),
                Add(1.45, 0.4265),
                Add(1.46, 0.4279),
                Add(1.47, 0.4292),
                Add(1.48, 0.4306),
                Add(1.49, 0.4319),

                Add(1.50, 0.4332),
                Add(1.51, 0.4345),
                Add(1.52, 0.4357),
                Add(1.53, 0.4370),
                Add(1.54, 0.4382),
                Add(1.55, 0.4394),
                Add(1.56, 0.4406),
                Add(1.57, 0.4418),
                Add(1.58, 0.4429),
                Add(1.59, 0.4441),

                Add(1.60, 0.4452),
                Add(1.61, 0.4463),
                Add(1.62, 0.4474),
                Add(1.63, 0.4484),
                Add(1.64, 0.4495),
                Add(1.65, 0.4505),
                Add(1.66, 0.4515),
                Add(1.67, 0.4525),
                Add(1.68, 0.4535),
                Add(1.69, 0.4545),

                Add(1.70, 0.4554),
                Add(1.71, 0.4564),
                Add(1.72, 0.4573),
                Add(1.73, 0.4582),
                Add(1.74, 0.4591),
                Add(1.75, 0.4599),
                Add(1.76, 0.4608),
                Add(1.77, 0.4616),
                Add(1.78, 0.4625),
                Add(1.79, 0.4633),

                Add(1.80, 0.4641),
                Add(1.81, 0.4649),
                Add(1.82, 0.4656),
                Add(1.83, 0.4664),
                Add(1.84, 0.4671),
                Add(1.85, 0.4678),
                Add(1.86, 0.4686),
                Add(1.87, 0.4693),
                Add(1.88, 0.4699),
                Add(1.89, 0.4706),

                Add(1.90, 0.4713),
                Add(1.91, 0.4719),
                Add(1.92, 0.4726),
                Add(1.93, 0.4732),
                Add(1.94, 0.4738),
                Add(1.95, 0.4744),
                Add(1.96, 0.4750),
                Add(1.97, 0.4756),
                Add(1.98, 0.4761),
                Add(1.99, 0.4767),

                Add(2.00, 0.4772),
                Add(2.01, 0.4778),
                Add(2.02, 0.4783),
                Add(2.03, 0.4788),
                Add(2.04, 0.4793),
                Add(2.05, 0.4798),
                Add(2.06, 0.4803),
                Add(2.07, 0.4808),
                Add(2.08, 0.4812),
                Add(2.09, 0.4817),

                Add(2.10, 0.4821),
                Add(2.11, 0.4826),
                Add(2.12, 0.4830),
                Add(2.13, 0.4834),
                Add(2.14, 0.4838),
                Add(2.15, 0.4842),
                Add(2.16, 0.4846),
                Add(2.17, 0.4850),
                Add(2.18, 0.4854),
                Add(2.19, 0.4857),

                Add(2.20, 0.4861),
                Add(2.21, 0.4864),
                Add(2.22, 0.4868),
                Add(2.23, 0.4871),
                Add(2.24, 0.4875),
                Add(2.25, 0.4878),
                Add(2.26, 0.4881),
                Add(2.27, 0.4884),
                Add(2.28, 0.4887),
                Add(2.29, 0.4890),

                Add(2.30, 0.4893),
                Add(2.31, 0.4896),
                Add(2.32, 0.4898),
                Add(2.33, 0.4901),
                Add(2.34, 0.4904),
                Add(2.35, 0.4906),
                Add(2.36, 0.4909),
                Add(2.37, 0.4911),
                Add(2.38, 0.4913),
                Add(2.39, 0.4916),

                Add(2.40, 0.4918),
                Add(2.41, 0.4920),
                Add(2.42, 0.4922),
                Add(2.43, 0.4925),
                Add(2.44, 0.4927),
                Add(2.45, 0.4929),
                Add(2.46, 0.4931),
                Add(2.47, 0.4932),
                Add(2.48, 0.4934),
                Add(2.49, 0.4936),

                Add(2.50, 0.4938),
                Add(2.51, 0.4940),
                Add(2.52, 0.4941),
                Add(2.53, 0.4943),
                Add(2.54, 0.4945),
                Add(2.55, 0.4946),
                Add(2.56, 0.4948),
                Add(2.57, 0.4949),
                Add(2.58, 0.4951),
                Add(2.59, 0.4952),

                Add(2.60, 0.4953),
                Add(2.61, 0.4955),
                Add(2.62, 0.4956),
                Add(2.63, 0.4957),
                Add(2.64, 0.4959),
                Add(2.65, 0.4960),
                Add(2.66, 0.4961),
                Add(2.67, 0.4962),
                Add(2.68, 0.4963),
                Add(2.69, 0.4964),

                Add(2.70, 0.4965),
                Add(2.71, 0.4966),
                Add(2.72, 0.4967),
                Add(2.73, 0.4968),
                Add(2.74, 0.4969),
                Add(2.75, 0.4970),
                Add(2.76, 0.4971),
                Add(2.77, 0.4972),
                Add(2.78, 0.4973),
                Add(2.79, 0.4974),

                Add(2.80, 0.4974),
                Add(2.81, 0.4975),
                Add(2.82, 0.4976),
                Add(2.83, 0.4977),
                Add(2.84, 0.4977),
                Add(2.85, 0.4978),
                Add(2.86, 0.4979),
                Add(2.87, 0.4979),
                Add(2.88, 0.4980),
                Add(2.89, 0.4981),

                Add(2.90, 0.4981),
                Add(2.91, 0.4982),
                Add(2.92, 0.4982),
                Add(2.93, 0.4983),
                Add(2.94, 0.4984),
                Add(2.95, 0.4984),
                Add(2.96, 0.4985),
                Add(2.97, 0.4985),
                Add(2.98, 0.4986),
                Add(2.99, 0.4986),

                Add(3.00, 0.4987),
                Add(3.01, 0.4987),
                Add(3.02, 0.4987),
                Add(3.03, 0.4988),
                Add(3.04, 0.4988),
                Add(3.05, 0.4989),
                Add(3.06, 0.4989),
                Add(3.07, 0.4989),
                Add(3.08, 0.4990),
                Add(3.09, 0.4990),
           };

            foreach (var item in lista)
            {
                var calc = TabelaDistribuicao.Calcular(item.Item1);

                Assert.IsTrue(calc == item.Item2, $"Cálculo para {item.Item1}: {calc} != {item.Item2}");
            }
        }
    }
}
