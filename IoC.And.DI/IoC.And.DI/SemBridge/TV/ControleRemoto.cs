namespace IoC.And.DI.SemBridge.TV
{
    public abstract class ControleRemoto
    {
        public abstract void Ligar();

        public abstract void Desligar();

        public abstract void Sintonizar(int canal);
    }

    public class TvTubo : ControleRemoto
    {
        public override void Desligar()
        {
            // Desligar a TV
        }

        public override void Ligar()
        {
            // Ligar a TV
        }

        public override void Sintonizar(int canal)
        {
            // Apresentar o canal passado por parametro
        }
    }

    public class SmartTv : ControleRemoto
    {
        public override void Desligar()
        {
            // Desligar a TV
        }

        public override void Ligar()
        {
            // Ligar a TV
        }

        public override void Sintonizar(int canal)
        {
            // Apresentar o canal passado por parametro
        }
    }
}