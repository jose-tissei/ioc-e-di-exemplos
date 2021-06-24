namespace IoC.And.DI.ComDI.LojaOnline.Notificacoes
{
    public interface Notificacao
    {
        void Notificar(string destinatario, string assunto, string corpo);
    }
}