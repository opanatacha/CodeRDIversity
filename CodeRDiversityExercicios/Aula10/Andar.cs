using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRDiversityExercicios.Aula10
{
    public class Andar
    {
        public int NumeroContainers { get; set; }
        public List<Container> Containers { get; set; }

        public Andar(int numeroContainers, int numeroPosicoesContainer)
        {
            NumeroContainers = numeroContainers;
            Containers = new List<Container>();

            for (int i = 0; i < NumeroContainers; i++)
            {
                Container container = new Container(numeroPosicoesContainer);

                Containers.Add(container);
            }
        }

        public void AdicionarItem(int posicaoContainer, int posicaoItem, string item)
        {
            if (posicaoContainer < 0 || posicaoContainer > NumeroContainers)
            {
                Console.WriteLine("Container inválido!");
            }
            else
            {
                bool containerOcupado = Containers[posicaoContainer].EstaOcupado();

                if (containerOcupado)
                {
                    Console.WriteLine("Container cheio!");
                }
                else
                {
                    Containers[posicaoContainer].AdicionarItem(posicaoItem,item);
                }
            }
        }

        public void RemoverItem(int posicaoContainer, int posicaoItem)
        {
            if (posicaoContainer < 0 || posicaoContainer > NumeroContainers)
            {
                Console.WriteLine("Container inválido!");
            }
            else
            {
                Containers[posicaoContainer].RemoverItem(posicaoItem);
            }
        }

    }
}
