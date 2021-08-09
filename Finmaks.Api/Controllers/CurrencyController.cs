using Finmaks.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finmaks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : Controller
    {
        private ICurrencyServices _currencyServices;
        public CurrencyController(ICurrencyServices currencyServices)
        {
            _currencyServices = currencyServices;
        }
        [HttpGet("GetLastCurrencies")]
        public IActionResult GetLastCurrencies()
        {
          var getCurrency=  _currencyServices.GetAll();
            return Ok(getCurrency);
        }
    }
}
