using Finmaks.Data;
using Finmaks.Data.EntityFramework;
using Finmaks.Data.Services;
using Finmaks.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Finmaks.Controllers
{
    public class CurrencyController : Controller
    {
        private ICurrencyServices _currencyServices;

        public CurrencyController(ICurrencyServices currencyServices)
        {
            _currencyServices = currencyServices;
           
        }
        public IActionResult Index()
        {
            var result=_currencyServices.GetAll();
            return View(result);
        }
       
        public IActionResult Add(Currency currency)
        {
            
            XmlDocument doc = new XmlDocument();
            doc.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes =  root.SelectNodes("Currency");

            foreach (XmlNode node in nodes)
            {
                currency.Unit = node["Unit"].InnerText;
                currency.Isim = node["Isim"].InnerText;
                currency.CurrencyName = node["CurrencyName"].InnerText;
                currency.ForexBuying = node["ForexBuying"].InnerText;
                currency.ForexSelling = node["ForexSelling"].InnerText;
                currency.BanknoteBuying = node["BanknoteBuying"].InnerText;
                currency.BanknoteSelling = node["BanknoteSelling"].InnerText;
                currency.CrossRateUSD = node["CrossRateUSD"].InnerText;
                currency.CrossRateOther = node["CrossRateOther"].InnerText;

                _currencyServices.Add(currency);
       
            }

            return View();
        }
        public IActionResult Update(Currency currency)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("Currency");

            foreach (XmlNode node in nodes)
            {
                currency.Unit = node["Unit"].InnerText;
                currency.Isim = node["Isim"].InnerText;
                currency.CurrencyName = node["CurrencyName"].InnerText;
                currency.ForexBuying = node["ForexBuying"].InnerText;
                currency.ForexSelling = node["ForexSelling"].InnerText;
                currency.BanknoteBuying = node["BanknoteBuying"].InnerText;
                currency.BanknoteSelling = node["BanknoteSelling"].InnerText;
                currency.CrossRateUSD = node["CrossRateUSD"].InnerText;
                currency.CrossRateOther = node["CrossRateOther"].InnerText;

               
               

                _currencyServices.Update(currency);

            }

            return View();
        }
    }
}
