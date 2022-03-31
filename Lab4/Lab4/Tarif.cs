using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Tarif
    {
        private double tarif_price = 100;
        public double Get_price()
        {
            return tarif_price;
        }
        public void Set_price(double pr)
        {
            tarif_price = pr;
        }
        public void Up_price()
        {
            if (tarif_price + 10 < 1000)
            tarif_price += 10;
        }
        public void Down_price()
        {
            if (tarif_price - 10 > 0)
            tarif_price -= 10;
        }
    }
}
