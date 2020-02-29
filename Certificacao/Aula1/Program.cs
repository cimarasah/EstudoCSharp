using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Aula1
{
    class Program
    {
        const int length = 300;

        

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Parallel.Invoke(() => ImprimirZero(), () => ImprimirUm(), () => ImprimirPonto());
            stopwatch.Stop();
            System.Console.WriteLine("A Tarefa foi finalizada {0}", stopwatch.ElapsedMilliseconds / 1000.00);

            stopwatch.Reset();

            
            stopwatch.Start();

            ImprimirZero();
            ImprimirUm();
            ImprimirPonto();
            
            stopwatch.Stop();
            System.Console.WriteLine("A Tarefa foi finalizada {0}", stopwatch.ElapsedMilliseconds/ 1000.00);
        }

        private static void ImprimirUm()
        {
            for (int i=0; i < length; i++)
            {
                ExecutarTarefaDemorada();
                System.Console.Write("1");
            }
        }


        private static void ImprimirPonto()
        {
            for (int i = 0; i < length; i++)
            {
                ExecutarTarefaDemorada();
                System.Console.Write(".");
            }
        }

        private static void ImprimirZero()
        {
            for (int i = 0; i < length; i++)
            {
                ExecutarTarefaDemorada();
                System.Console.Write("0");
            }
        }
        private static void ExecutarTarefaDemorada()
        {
            Thread.Sleep(10);
        }
    }
}
