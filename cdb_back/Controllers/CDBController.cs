using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace cdb_back.Controllers
{
    [Route("api/[controller]")]
    public class CDBController : ControllerBase
    {
        public ActionResult<decimal> CalcularCDB([FromBody] Investimento investimento)
        {
            //Valores fixos do exercício
            decimal TB = 1.08m;  // 108%
            decimal CDI = 0.009m;  // 0.9%

            //Fórmula do CDB
            decimal VF = investimento.ValorInicial * (1 + (investimento.CDIUltimoMes * TB));

            //Retorna o valor final do investimento
            return VF;
        }
    }
}