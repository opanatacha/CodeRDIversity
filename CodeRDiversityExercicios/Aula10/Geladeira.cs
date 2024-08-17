using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRDiversityExercicios.Aula10
{
    public class Geladeira
    {
        public int NumeroAndares { get; set; }
        public List<Andar> Andares { get; set; }

        public Geladeira(int numeroAndares, int numeroContainers, int numeroPosicoesContainer)
        {
            NumeroAndares = numeroAndares;
            Andares = new List<Andar>();

            for (int i = 0; i < NumeroAndares; i++)
            {
                Andar andar = new Andar(numeroContainers, numeroPosicoesContainer);

                Andares.Add(andar);
            }
        }
    }
}
