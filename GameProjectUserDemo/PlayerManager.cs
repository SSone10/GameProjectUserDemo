using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectUserDemo
{
    class PlayerManager
    {
        public void Dogrulama(Player player)
        {
            Console.WriteLine("KULLANICI : "+"ADI :"+player.Ad+" - "+" OYUN ADI :"+player.OyunAdı+" - "+"SOYADI :"+player.Soyad+" - "+"DOĞUM YILI :"+player.DogumYılı);
        }
        public void Güncelleme(Player player)
        {
            Console.WriteLine("KULLANICI : " + "ADI :" + player.Ad + " - " + " OYUN ADI :" + player.OyunAdı + " - " + "SOYADI :" + player.Soyad + " - " + "DOĞUM YILI :" + player.DogumYılı+" - "+"BİLGİLERİ GÜNCELLENDİ");
        }
        public void Silme(Player player)
        {
            Console.WriteLine("KULLANICI : " + "ADI :" + player.Ad + " - " + " OYUN ADI :" + player.OyunAdı + " - " + "SOYADI :" + player.Soyad + " - " + "DOĞUM YILI :" + player.DogumYılı+" - "+"BİLGİLERİ SİLİNDİ");
        }
    }
}
