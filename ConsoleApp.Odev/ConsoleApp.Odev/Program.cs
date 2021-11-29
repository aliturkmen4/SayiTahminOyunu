using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Odev
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int counter = 1;
                int guess;

                Random rnd = new Random();
                int desirednumber = rnd.Next(0, 100);

                do
                {
                    Console.Write(counter + ". Tahmininizi giriniz: ");
                    guess = int.Parse(Console.ReadLine());

                    if (guess < 100 && guess > 0)
                    {
                        if ((guess > desirednumber) && counter <= 10)
                        {
                            Console.WriteLine("Down");
                        }

                        else if ((guess < desirednumber) && counter <= 10)
                        {
                            Console.WriteLine("Up");
                        }

                        else if (guess == desirednumber)
                        {
                            Console.WriteLine("Congratulations.. " + counter + ". denemede bildiniz. ");
                        }

                        counter++;

                        if (counter > 10)
                            Console.WriteLine("Hakkınız doldu!\nPlay Again!");
                    }
                    else
                    {                 
                        Console.WriteLine("0-100 arası girin lütfen!");
                    }
                  
                }
                while ((guess != desirednumber) && counter <= 10);

            }
            catch (OverflowException autumn)
            {
                Console.WriteLine(autumn.Message);
            }
            catch (FormatException summer)
            {
                Console.WriteLine(summer.Message);
            }
            catch (Exception winter)
            {
                Console.WriteLine(winter.Message);
            }
            Console.ReadLine();
        }
    }
}
