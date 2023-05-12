namespace ChainOfResponsability.Handler
{
    public abstract class Autorizador
    {   
        protected Autorizador _autorizador;

        public void ProximoAutorizador(Autorizador autorizador)
        {
            _autorizador = autorizador;
        }

        public abstract void AutorizarLicenca(string nome, int dias);
    }
}
