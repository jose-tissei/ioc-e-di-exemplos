namespace IoC.And.DI.ComDI.BotaoELampada
{
    public interface Acionavel
    {
        void Ligar();

        void Desligar();
    }

    public class Lampada : Acionavel
    {
        public void Ligar()
        {
            // Acende a luz
        }

        public void Desligar()
        {
            // Apaga a Luz
        }
    }

    public class Botao
    {
        private bool _pressionado;
        private Acionavel _acionavel;

        public Botao(Acionavel acionavel)
        {
            _acionavel = acionavel;
        }

        public void Pressionar()
        {
            if (_pressionado)
            {
                _acionavel.Desligar();
                _pressionado = false;
            }
            else
            {
                _acionavel.Ligar();
                _pressionado = true;
            }
        }
    }

    public class Motor : Acionavel
    {
        public void Ligar()
        {
            // Ligar o motor
        }

        public void Desligar()
        {
            // Desligar o motor
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var interruptorDeLuz = new Botao(new Lampada());
            var partidaDoCarro = new Botao(new Motor());
        }
    }
}