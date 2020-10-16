using System;

namespace zar
{
    class Program
    {
        static void Main(string[] args)
        {
            Random zar = new Random();

            int roll1 = zar.Next(1,7);
            int roll2 = zar.Next(1,7);
            int roll3 = zar.Next(1,7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Zar Dönüyor : {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("Üçlü Attınız! +6 Bonus Puan eklendi.");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("Çifte attınız! +2 Bonus Puan eklendi.");
                    total += 2;
                }

            }
            
                if (total >=16)
                {
                Console.WriteLine("R-34 Model bir Nissan araba kazandınız, tebrikler.");
                }
                else if (total >=10)
                {
                Console.WriteLine("Nvidia Geforce RX 580 (8 GB) Ekran Kartı Kazandınız, tebrikler.");
                }
                else if (total == 7)
                {
                Console.WriteLine("Eyüb Sabri Tuncer Japon Kiraz Çiçeği Kolonya kazandınız, tebrikler.");
                }
                else
                {
                Console.WriteLine("Hiçbir şey kazanamadınız , tekrar denemenizi istirham ediyorum. ");
            }         
        }        
}
}
