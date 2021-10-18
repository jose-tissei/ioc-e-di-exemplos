namespace IoC.And.DI.ComBridge.TV
{
    public interface TV
    {
        public void Ligar();

        public void Desligar();

        public void Sintonizar(int canal);
    }

    public class TvTubo : TV
    {
        public void Desligar()
        {
            // Desligar a TV
        }

        public void Ligar()
        {
            // Ligar a TV
        }

        public void Sintonizar(int canal)
        {
            // Apresentar o canal passado por parametro
        }

        public void SintoniaFina(float frequencia)
        {
            // Sintonizar canal na frequencia informada
        }
    }

    public class SmartTv : TV
    {
        public void Desligar()
        {
            // Desligar a TV
        }

        public void Ligar()
        {
            // Ligar a TV
        }

        public void Sintonizar(int canal)
        {
            // Apresentar o canal passado por parametro
        }

        public void Youtube()
        {
            // Abre o aplicativo do Youtube
        }

        public void NavegadorWeb()
        {
            // Abre o aplicativo do Navegador Web
        }
    }
}