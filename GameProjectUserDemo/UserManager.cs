namespace GameProjectUserDemo
{
    class UserManager 
    {
       public void KullanıcıKontrol(IUserService userService)
        {
            userService.KullanıcıKontrol();
        }
        public void KullanıcıLog(ILoggerService loggerService)
        {
            loggerService.LogServis();
        }
    }
}
