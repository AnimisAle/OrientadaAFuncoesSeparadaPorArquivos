using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo

{
    internal class Media
    {
        public static void Aluno()
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine("\nDigite as " + qtdNotas + " notas do aluno:  " + nome);

            List<double> notas = new List<double>();
            double mediaAluno = 0;

            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota numero " + i);
                double nota = double.Parse(Console.ReadLine());
                mediaAluno += nota / 3;
                notas.Add(nota);
            }
            double totalNota = notas.Count;

            Console.WriteLine("A média do aluno " + nome + " é: " + mediaAluno);
            Console.WriteLine(" Suas notas são: \n");
            foreach (double nota in notas)
            {
                Console.WriteLine("Nota: " + nota + "\n");
            }
        }
    }
}
