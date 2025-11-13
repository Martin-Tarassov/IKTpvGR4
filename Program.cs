using System.ComponentModel.Design;

namespace SwitchBetweenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //esimene koondtulemus puhul on number vahemikus 
         //0 kuni 100,
         //teise puhul 101 kuni 200 ja 
         //kolmanda puhul 201 kuni 300
         //kasutada switchi
         string input = Console.ReadLine();
            
            int number = 150;


            int range = number / 100;
            switch (range) 
            { 
             
                case >= 0 and <= 100:              
                 Console.WriteLine("0 kuni 100");               
                break;
                
                
                
                case >= 101 and <= 200:               
                Console.WriteLine("101 kuni 200");                
                break;



                case >= 201 and <= 300:              
                Console.WriteLine("201 kuni 300");                
                break;

                
                
                
                default:
                Console.WriteLine("ei ole");
                break;



            }
        }
    }
}
