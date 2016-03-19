﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EstatisticaFatec.Helper
{
    public static class EstatisticaHelper  
    {
        public static MvcHtmlString Rol(this HtmlHelper h, List<decimal> inputRol)
        {
            var formatada = string.Join(" - ", inputRol.Select(q=> $"[{q}]"));
            return new MvcHtmlString(formatada);
        }
    }
}