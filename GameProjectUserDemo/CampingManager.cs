using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectUserDemo
{
    class CampingManager
    {
        public void KampanyaEkle(Camping camping)
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            Console.WriteLine("KAMPANYA ADI :"+camping.KampanyaAdı+" - "+"KAMPANYA DÖNEMİ :"+" "+camping.KampanyaDönemi+" - "+"KAMPANYA ORANI :"+camping.KampanyaOranı+" - "+"UYGULANDI");
        }
    }
}
