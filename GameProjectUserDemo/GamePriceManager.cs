using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectUserDemo
{
    class GamePriceManager
    {
        public void OyunSatış(Player player,Product product,Camping camping)
        {
            product.OyunFiyatı = product.OyunFiyatı - (product.OyunFiyatı / camping.KampanyaOranı);
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine(product.OyunFiyatı+"$    "+"KARŞILIĞINDA "+player.Ad +" "+product.OyunAdı + " ADLI OYUNU SATIN ALDI");
        }
    }
}
