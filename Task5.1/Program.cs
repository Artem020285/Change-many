namespace Task5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целую часть - ");
            int numm1 = int.Parse(Console.ReadLine());
            Console.Write("Введите копеешную часть - ");
            int numm2 = int.Parse(Console.ReadLine());
            Console.WriteLine("////////////////////////");

            Evro evro = new Evro(numm1, numm2);
            evro.WholeE(numm1);
            evro.PennE(numm2);
            Console.WriteLine("------------------\n");

            Dollar dollar = new Dollar(numm1, numm2);
            dollar.WholeD(numm1);
            dollar.PennD(numm2);
            Console.WriteLine("------------------\n");

            Rybl rybl = new Rybl(numm1, numm2);
            rybl.WholeR(numm1);
            rybl.PennR(numm2);
            Console.WriteLine("------------------\n");

            Console.ReadKey();
        }
    }
}