using Finmaks.Data.EntityFramework;
using Finmaks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finmaks.Data.Services
{
    public class CurrencyManager : ICurrencyServices
    {
        ICurrencyDal _currencyDal; 
        public CurrencyManager(ICurrencyDal currencyDal)
        {
            _currencyDal = currencyDal;
        }
        public void Add(Currency currency)
        {
            _currencyDal.Add(currency);
        }

        public List<Currency> GetAll()
        {
          return _currencyDal.GetAll();
        }

        public void Update(Currency currency)
        {
            _currencyDal.Update(currency);
        }
    }
}
