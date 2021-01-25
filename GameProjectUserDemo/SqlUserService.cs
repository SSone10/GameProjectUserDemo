using System;

namespace GameProjectUserDemo
{
    class SqlUserService : IUserService, ILoggerService
    {
        public void KullanıcıKontrol()
        {
            
            Console.WriteLine("KULLANICI SQL VERİTABANINDA DOĞRULANDI");
        }

        public void LogServis()
        {
            Console.WriteLine("KULLANICI SQL'E LOGLANDI");
        }
    }
}
