using Observer.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subject
{
    public class ConcreteSubject : ISubject
    {
        public ConcreteSubject(string produto, string preco, string disponibilidade)
        {
            Produto = produto;
            Preco = preco;
            Disponibilidade = disponibilidade;
        }

        private readonly List<IObserver> Observers = new();
        private string Produto { get; set; }
        private string Preco { get; set; }
        private string Disponibilidade { get; set; }

        public string GetDisponibilidade() => Disponibilidade;

        public void SetDisponibilidade(string Status)
        {
            Disponibilidade = Status;
            Console.WriteLine($"A disponibilidade mudou de 'Sem estoque' para 'Disponível'");
            NotificarObservers();
        }


        public void NotificarObservers()
        {
            Console.WriteLine($"O produto {Produto} no valor {Preco} agora está com o status '{Disponibilidade}'");

            foreach (var observer in Observers)
            {
                observer.Atualizar(Disponibilidade);
            }
        }

        public void RegistrarObserver(IObserver observer)
        {
            Console.WriteLine($"Cliente {observer.Usuario} adicionado na lista de observadores!");
            Observers.Add(observer);
        }

        public void RemoverObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}
