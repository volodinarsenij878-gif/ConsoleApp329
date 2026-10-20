using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program169
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Режим АКПП (P/R/N/D/M): ");
            string mode = Console.ReadLine()?.Trim().ToUpper();
            if (string.IsNullOrEmpty(mode) || mode.Length != 1)
            {
                Console.WriteLine("Ошибка.");
                return;
            }

            string desc;
            switch (mode[0])
            {
                case 'P': desc = "Парковка (Parking)"; break;
                case 'R': desc = "Задний ход (Reverse)"; break;
                case 'N': desc = "Нейтраль (Neutral)"; break;
                case 'D': desc = "Движение (Drive)"; break;
                case 'M': desc = "Ручной режим (Manual)"; break;
                default:
                    Console.WriteLine("Неизвестный режим.");
                    return;
            }
            Console.WriteLine(desc);
        }
    }
}
