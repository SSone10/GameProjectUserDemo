using System;

namespace GameProjectUserDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Ad = "MUHAMMED";
            player1.Soyad = "ACIBALIK";
            player1.DogumYılı = "28/03/1999";
            player1.OyunAdı = "Tuhender";
            player1.TcNo = "12345678901";

            Player player2 = new Player();
            player2.Ad = "GÖKHAN";
            player2.Soyad = "ARAÇ";
            player2.DogumYılı = "29/03/1999";
            player2.OyunAdı = "BOSS";
            player2.TcNo = "01123456789";

            PlayerManager playerManager = new PlayerManager();
            playerManager.Dogrulama(player1);
            playerManager.Güncelleme(player2);
            playerManager.Silme(player1);

            Camping camping = new Camping();
            camping.KampanyaAdı = "HERKES OYUNA";
            camping.KampanyaDönemi = "KIŞ";
            camping.KampanyaOranı=2;

            CampingManager campingManager = new CampingManager();
            campingManager.KampanyaEkle(camping);

            Product product = new Product();
            product.OyunAdı = "COD 5";
            product.OyunFiyatı = 1250;

            GamePriceManager gamePriceManager = new GamePriceManager();
            gamePriceManager.OyunSatış(player1,product,camping);

            SqlUserService sqlUserService = new SqlUserService();
            OracleUserService oracleUserService = new OracleUserService();
            KullanıcıKontrol kullanıcıKontrol = new KullanıcıKontrol();

            UserManager userManager = new UserManager();
            userManager.KullanıcıKontrol(kullanıcıKontrol);
            userManager.KullanıcıKontrol(sqlUserService);
            userManager.KullanıcıLog(sqlUserService);
            
        }
    }
}
