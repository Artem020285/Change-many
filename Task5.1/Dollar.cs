

namespace Task5._1
{
    internal class Dollar : Exchange
    {
        public Dollar(double wholePart, double pennies) : base(wholePart, pennies) { }

        public void WholeD(double wholePart)
        {
            double summR = wholePart * 64.02;
            Console.Write($"Рубля от Доллара целой части:  {summR}\n");
            double summE = wholePart * 0.97;
            Console.Write($"Эвро от Доллара целой части: {summE}\n");
        }

        public void PennD(double pennies)
        {
            double penR = pennies * 64.02;
            Console.Write($"Рублей от Доллара копеек:  {penR}\n");
            double penE = pennies * 0.97;
            Console.Write($"Эвро от Доллара копеек: {penE}\n");
        }
    }
}
