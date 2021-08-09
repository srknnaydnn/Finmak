

using Finmaks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finmaks.Data.EntityFramework
{
    public class CurrencyDal: EfEntityRepository<Currency,Context>,ICurrencyDal
    {
    }
}
