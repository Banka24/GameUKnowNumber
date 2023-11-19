using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("Игра угадай число. У вас 3 попытки");
            int NumberAI = rand.Next(0, 100); //Число компьтера задается рандомно
            int tryers = 3; //Количество попыток

            while (tryers > 0)
            {
                Console.WriteLine($"У вас осталось{tryers} потпыток.\nВведите своё число:");
                int NumberUser = int.Parse(Console.ReadLine());                

                if(NumberUser == NumberAI)
                {
                    Console.WriteLine($"Вы угадали, это число {NumberUser}");
                    break;
                }
                else
                {
                    if(NumberUser < NumberAI)
                    {
                        Console.WriteLine("Ваше число меньше числа компьютера.");
                    }
                    else
                    {
                        Console.WriteLine("Ваше число меньше числа компьютера.");
                    }                
                }
                tryers--;
            }

            if(tryers > 0)
            {
                Console.WriteLine("Поздравляем с победой!");
            }
            else
            {
                Console.WriteLine("Не расстраивайтесь, попробуйте заново.");
            }

        }
    }
}
