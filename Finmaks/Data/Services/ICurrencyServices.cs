using Finmaks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finmaks.Data.Services
{
    public interface ICurrencyServices
    {
        List<Currency> GetAll();
        void Add(Currency currency);
        void Update(Currency currency);
    }
}
