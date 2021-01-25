using System;

namespace GameProjectUserDemo
{
    class OracleUserService : IUserService, ILoggerService
    {
        public void KullanıcıKontrol()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("KULLANICI ORACLE VERİTABANINDA DOĞRULANDI");
        }

        public void LogServis()
        {
            Console.WriteLine("KULLANICI ORACLE'E LOGLANDI");
        }
    }
}
