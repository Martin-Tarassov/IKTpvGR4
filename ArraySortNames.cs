namespace ArraySottNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kasutame Array ja Sort-i");
            string[] animals = {"cat", "alligator","fox",
                "donkey","bear","elephant","goat" };
            //tuleb kasutada foreachi ka n idata kõiki loomi
            //paneb kõik tähestikulisse järjelprda
            //Array.Sort(animals)
            Array.Sort(animals);
            foreach (string i in animals)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------------");
            //järjesta kolm esimest sõna tähestikulises järjestuses
            //vaadake Sort meetodit ja mitu overload sel on

            Array.Sort(animals, 0, 3);
            foreach (string i in animals)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------------------------");
            int[] numbers = { 1, 2, 3, 4, 3, 55, 23, 2 };
            var distinct = numbers.Distinct().ToArray();
            foreach (int num in distinct)
            {
                Console.WriteLine(num);
            }

            //Tuleb välistada korused
            //mida teha ,et numbrid et korduks


        }
    }
}
