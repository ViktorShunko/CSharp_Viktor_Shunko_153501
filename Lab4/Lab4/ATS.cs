using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class ATS
    {
        public static ATS ats;
        private Tarif tar;

        private int number = 0;
        private double abonent_price = 30.0;
        private string name = "My ATS";

        private ATS()
        {
        }
        public double AbonentPriceAll()
        {
            return abonent_price * number;
        }
        public int GetNumber()
        {
            return number;
        }
        public double GetAbonentPrice()
        {
            return abonent_price;
        }
        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return tar.Get_price();
        }
        public void UpPrice()
        {
            tar.Up_price();
        }
        public void DownPrice()
        {
            tar.Down_price();
        }
    }
}