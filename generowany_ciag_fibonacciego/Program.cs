namespace generowany_ciag_fibonacciego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            int dlugosc;
            Console.WriteLine("Podaj jakiej długości ma być twój ciąg Fibonacciego: ");
            dlugosc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Twój ciąg będzie składał z " + dlugosc + " elementów");
             Console.WriteLine("Podaj pierwszą liczbę ciągu: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę ciągu: ");
            b = double.Parse(Console.ReadLine());
            for(int i = 0; i < dlugosc; i++)
            {
                double c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;

            }
        }
    }
}