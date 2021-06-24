using System;

namespace IoC.And.DI.SemDI.LojaOnline
{
    public static class Logger
    {
        public static void Log(string mensagem)
        {
            Console.WriteLine($"Log @ {mensagem}: {DateTime.UtcNow}");
        }
    }
}