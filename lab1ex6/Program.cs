namespace lab1ex1
{
    class Program
    {
        /*Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
        descrescatoare.
        */
        static void Main(string[] args)
        {
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            double[] numberList = new double[]{ a, b, c } ;
            Array.Sort(numberList);
            foreach(double number in numberList.Reverse())
            {
                Console.WriteLine(number);
            }
            

        }
    }
}