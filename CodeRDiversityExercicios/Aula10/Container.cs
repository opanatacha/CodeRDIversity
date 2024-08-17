using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRDiversityExercicios.Aula10
{
    public class Container
    {
        public int NumeroPosicoes { get; set; }
        public List<string> Itens { get; set; }

        public Container(int numeroPosicoes)
        {
            NumeroPosicoes = numeroPosicoes;
            Itens = new List<string>();

            for (int i = 0; i < NumeroPosicoes; i++)
            {
                Itens.Add("");
            }
        }

        public void AdicionarItem(int posicaoItem, string item)
        {
            if (posicaoItem >= 0 && posicaoItem < NumeroPosicoes)
            {
                if (Itens[posicaoItem] != "")
                {
                    Console.WriteLine("Posição ocupada!");
                }
                else
                {
                    Itens[posicaoItem] = item;
                    Console.WriteLine("Adicionado o item" + item + "!");
                }
            }
            else
            {
                Console.WriteLine("Posição inválida!");
            }
        }

        public void RemoverItem(int posicaoItem)
        {
            if (posicaoItem >= 0 && posicaoItem < NumeroPosicoes)
            {
                if (Itens[posicaoItem] == "")
                {
                    Console.WriteLine("Posição já está vazia!");
                }
                else
                {
                    string item = Itens[posicaoItem];
                    Itens[posicaoItem] = "";
                    Console.WriteLine("O item " + item + " foi removido!");
                }
            }
            else
            {
                Console.WriteLine("Posição inválida!");
            }
        }

        public bool EstaOcupado()
        {
            foreach (string item in Itens)
            {
                if (item != "")
                {
                    return false;
                }
            }

            return true;
        }
    }
}
