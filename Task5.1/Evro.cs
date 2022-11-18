

namespace Task5._1
{
    public class Evro : Exchange
    {
        
        public Evro(double wholePart, double pennies) : base(wholePart, pennies) { }

        public void WholeE(double wholePart)
        {
            double summR = wholePart * 0.016; 
            Console.Write($"Рублей от Эвро целой части:  {summR }\n");
            double summD = wholePart * 1.03;
            Console.Write($"Долларов от Эвро целой части: {summD}\n");
        }

        public void PennE(double pennies)
        {
            double penR = pennies * 0.016;
            Console.Write($"Рублей от Эвро копеек:  {penR}\n");
            double penD = pennies * 1.03;
            Console.Write($"Долларов от Эвро копеек: {penD}\n");
        }
        
    }
}
