using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double Capital;
            double Taxa;
            double ResultadoTaxa; 
            double Tempo;
            double Juros;
            double Montante;

            Console.Write("Digite o valor R$ : ");
            Capital = double.Parse(Console.ReadLine());

            Console.Write("Digite a taxa do juros R$ : ");
            Taxa = double.Parse(Console.ReadLine());

            Console.Write("Digite o tempo de parcelas : ");
            Tempo = double.Parse(Console.ReadLine());
            Console.Write("/n");

            ResultadoTaxa = Taxa / 100;
            Juros = Capital * Tempo;
            Console.WriteLine("Seus juros é = {0}", Juros);

            Montante = Capital + Juros;
            Console.WriteLine("Seu montante é = {0}", Montante);
            Console.Write("/n");

            Console.WriteLine(" click na tecla ENTER para sair ");
            Console.ReadKey();
        } 
    }
}
