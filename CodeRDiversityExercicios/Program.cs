using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeRDiversityExercicios.Aula05;
using CodeRDiversityExercicios.Aula10;

namespace CodeRDiversityExercicios
{
    public class Program
    {
        // Aluna: Natacha Aquino de Carvalho

        public static void Main(string[] args)
        {
            //Console.WriteLine("Aula 05 - Exercício 01");
            //Console.WriteLine("No meio da madrugada, bateu uma fome e você precisa ir até a geladeira.");
            //Console.WriteLine();
            //Console.WriteLine("Abrindo a geladeira...");
            //ExercicioAula05.ManusearGeladeira();

            Console.WriteLine("Aula 10 - Exercício 01");
            Console.WriteLine("Criando geladeira...");

            Geladeira geladeira = new Geladeira(3, 2, 4);

            Console.WriteLine("Aula 10 - Exercício 02");
            Console.WriteLine("Tentando remover item direto da primeira posição...");

            geladeira.Andares[0].Containers[0].RemoverItem(0);

            Console.WriteLine("Aula 10 - Exercício 03");
            Console.WriteLine("Tentando adicionar item direto na primeira posição...");

            geladeira.Andares[0].Containers[0].AdicionarItem(0, "Arroz");

            Console.WriteLine("Aula 10 - Exercício 04");
            Console.WriteLine("Tentando remover item da primeira posição do primeiro container...");

            geladeira.Andares[0].RemoverItem(0, 0);

            Console.WriteLine("Aula 10 - Exercício 05");
            Console.WriteLine("Tentando adicionar item na primeira posição do primeiro container...");

            geladeira.Andares[0].AdicionarItem(0, 0, "Arroz");



        }
    }
}
