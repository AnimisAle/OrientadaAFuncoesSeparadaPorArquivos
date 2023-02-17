using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    internal class Menu
    {
        public static void Criar()
        {
            while (true)
            {
                string Mensagem = "Olá, seja bem vindo ao programa, utilizando programação funcional... +" +
                    "\n Digite uma das opções abaixo: \n" +
                    "\n 0 - Sair do programa" +
                    "\n 1 - Para ler arquivos" +
                    "\n 2 - Para executar a tabuada" +
                    "\n 3 - Calcular media de alunos";

                Console.WriteLine(Mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("======= Opção de ler arquivos ======= \n");
                    Arquivo.Ler(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("======= Opção tabuada ======= \n");
                    Console.WriteLine("Digire o número que deseja na tabuada: ");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine("============================ \n");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("============================ \n");
                    Media.Aluno();
                }
                else
                {
                    Console.WriteLine("============================ \n");
                    Console.WriteLine("Opção inválida, digite uma das opções válidas...");
                    Console.WriteLine("============================ \n");
                }

            }
        }

        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
    }
}
