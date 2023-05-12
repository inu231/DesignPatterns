using Memento.Mementos;

namespace Memento.Originator
{
    public interface ICalculadora
    {
        /// <summary>
        /// Cria o memento
        /// </summary>
        /// <returns></returns>
        ICaretaker BackupUltimoCalculo();
        /// <summary>
        /// Set memento
        /// </summary>
        /// <returns></returns>
        void RestaurarUltimoCalculo(ICaretaker memento);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int GetCalculoResultado();
        /// <summary>
        /// 
        /// </summary>
        void SetPrimeiroNumero(int n);
        /// <summary>
        /// 
        /// </summary>
        void SetSegundoNumero(int n);
    }
}
