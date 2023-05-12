namespace Observer.Observers
{
    public interface IObserver
    {
        public string Usuario { get; set; }

        public void Atualizar(string Disponibilidade);
    }
}
