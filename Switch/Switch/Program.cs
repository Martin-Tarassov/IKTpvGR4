namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sissesta täht ja vajuta enter");
            string input = Console.ReadLine();
            switch (input) 
            {
              case "a":
                    Console.WriteLine("sissestasid tähe a");
                    break;
                   
                case "e":
                    Console.WriteLine("sissestasid tähe e");
                    break;
                   
                case "i":
                    
                    Console.WriteLine("sissestasid tähe i");
                    break;

                   
                default:
                    Console.WriteLine("ei ole vokaal");
                    break;

            }

        }
    }
}
