using System;
using System.Linq;

namespace CCC
{
    public enum Платежные_системы
    {
        Visa,
        MC,
        WU,
        Non
    }



    class Program
    {
        static void Main(string[] args)
        {
        	Карта[] cards = new Карта[5];
            cards[0] = new Карта("1234 1231 1232 2242", Платежные_системы.Non);
            
            cards[1] = new Накопительная("1234 1231 1232 5563", Платежные_системы.MC);

            cards[2] = new Платежная("1234 1231 1232 5563", Платежные_системы.Visa);

            cards[3] = new Зарплатная("1234 1231 1232 5563", Платежные_системы.WU);
			
            Console.WriteLine(cards.Length);
            for (int i = 0; i < cards.Length - 1; i++)
            {
                Console.WriteLine(">>>>>>>>" + cards[i].GetType().Name);
                Console.WriteLine("Данные карты " + cards[i].Номер_пол);
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
            


} 