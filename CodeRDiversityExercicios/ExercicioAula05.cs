using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRDiversityExercicios
{
    public class ExercicioAula05
    {
        public static void ManusearGeladeira()
        {
            string[,,] geladeira = new string[3, 2, 4];

            while (true)
            {
                Console.WriteLine("1. Adicionar produto na geladeira");
                Console.WriteLine("2. Exibir produtos da geladeira");
                Console.WriteLine("3. Fechar geladeira");

                string comando = Console.ReadLine();

                if (comando == "1")
                {
                    Console.Write("Nome do produto: ");
                    string produto = Console.ReadLine();

                    Console.Write("Andar (1 até 3): ");
                    int andar = int.Parse(Console.ReadLine()) - 1;

                    Console.Write("Container (1 até 2): ");
                    int container = int.Parse(Console.ReadLine()) - 1;

                    Console.Write("Posição (1 até 4): ");
                    int posicao = int.Parse(Console.ReadLine()) - 1;

                    geladeira[andar, container, posicao] = produto;
                }
                else if (comando == "2")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            for (int k = 0; k < 4; k++)
                            {
                                string produto = "Vazio";

                                if (geladeira[i, j, k] != null)
                                {
                                    produto = geladeira[i, j, k];
                                }

                                string andar = "";

                                if (i == 0)
                                {
                                    andar = $"Andar 1 (Hortifruti)";
                                }
                                else if (i == 1)
                                {
                                    andar = $"Andar 2 (Laticínios)";
                                }
                                else if (i == 2)
                                {
                                    andar = $"Andar 3 (Carnes)";
                                }

                                Console.WriteLine($"{andar}, Container {j + 1}, Posição {k + 1}: {produto}");
                            }
                        }
                    }
                }
                else if (comando == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Comando inválido!");
                }
            }
        }
    }
}
