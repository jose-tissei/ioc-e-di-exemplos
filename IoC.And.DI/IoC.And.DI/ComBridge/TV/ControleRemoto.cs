using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.And.DI.ComBridge.TV
{
    public abstract class ControleRemoto
    {
        private readonly TV tv;

        public ControleRemoto(TV tv)
        {
            this.tv = tv;
        }

        public void Desligar()
        {
            tv.Desligar();
        }

        public void Ligar()
        {
            tv.Ligar();
        }

        public void Sintonizar(int canal)
        {
            tv.Sintonizar(canal);
        }
    }

    public class ControleTvAnalogica : ControleRemoto
    {
        private readonly TvTubo tv;

        public ControleTvAnalogica(TvTubo tv) : base(tv)
        {
            this.tv = tv;
        }

        public void SintoniaFina(float frequencia)
        {
            tv.SintoniaFina(frequencia);
        }
    }

    public class ControleSmartTv : ControleRemoto
    {
        private readonly SmartTv tv;

        public ControleSmartTv(SmartTv tv) : base(tv)
        {
            this.tv = tv;
        }

        public void Youtube()
        {
            tv.Youtube();
        }

        public void NavegadorWeb()
        {
            tv.NavegadorWeb();
        }
    }
}