namespace SimpleFactory
{
    public interface IPizza
    {
        string Name { get; set; }

        void Preparar();
        void Assar();
        void Finalizar();        
    }
}
