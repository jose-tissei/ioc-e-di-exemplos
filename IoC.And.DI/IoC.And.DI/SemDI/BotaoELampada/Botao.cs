namespace IoC.And.DI.SemDI.BotaoELampada
{
    public class Lampada
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
        private Lampada _lampada;

        public Botao()
        {
            _lampada = new Lampada();
        }

        public void Pressionar()
        {
            if (_pressionado)
            {
                _lampada.Desligar();
                _pressionado = false;
            }
            else
            {
                _lampada.Ligar();
                _pressionado = true;
            }
        }
    }
}