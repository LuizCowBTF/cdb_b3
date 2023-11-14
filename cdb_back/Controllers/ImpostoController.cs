using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace cdb_back.Controllers
{
    [Route("api/[controller]")]
    public class ImpostoController : ControllerBase
    {
        public ActionResult<decimal> CalcularImposto(int meses)
        {
            if(meses <= 0)
                return 0.225m;  //22.5%
            else if(meses <= 12)
                return 0.20m;   //20%
            else if(meses <= 24)
                return 0.175m;  //17.5%
            else
                return 0.15m;   //15%
        }

    }
}