namespace FactoryMethod
{
    public interface IPizza
    {
        string Name { get; set; }

        void Preparar();
        void Assar();
        void Finalizar();        
    }
}
