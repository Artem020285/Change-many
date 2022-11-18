

namespace Task5._1
{
    internal class Rybl : Exchange
    {
        public Rybl(double wholePart, double pennies) : base(wholePart, pennies) { }

        public void WholeR(double wholePart)
        {
            double summR = wholePart * 64.02;
            Console.Write($"Доллара от Рубля целой части:  {summR}\n");
            double summE = wholePart * 62.67;
            Console.Write($"Эвро от Рубля целой части: {summE}\n");
        }

        public void PennR(double pennies)
        {
            double penR = pennies * 64.02;
            Console.Write($"Доллара от Рубля копеек:  {penR}\n");
            double penE = pennies * 62.67;
            Console.Write($"Эвро от Рубля копеек: {penE}\n");
        }
    }
}
