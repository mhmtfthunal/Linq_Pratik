using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        List<int> sayilar = new List<int>();

        // Rastgele 10 sayı (negatif de dahil olacak şekilde)
        for (int i = 0; i < 10; i++)
        {
            sayilar.Add(rnd.Next(-30, 31)); // -30 ile 30 arasında
        }

        Console.WriteLine("Oluşturulan Liste: " + string.Join(", ", sayilar));

        // 1) Çift sayılar
        var ciftler = sayilar.Where(s => s % 2 == 0);
        Console.WriteLine("\nÇift Sayılar: " + string.Join(", ", ciftler));

        // 2) Tek sayılar
        var tekler = sayilar.Where(s => s % 2 != 0);
        Console.WriteLine("Tek Sayılar: " + string.Join(", ", tekler));

        // 3) Negatif sayılar
        var negatifler = sayilar.Where(s => s < 0);
        Console.WriteLine("Negatif Sayılar: " + string.Join(", ", negatifler));

        // 4) Pozitif sayılar
        var pozitifler = sayilar.Where(s => s > 0);
        Console.WriteLine("Pozitif Sayılar: " + string.Join(", ", pozitifler));

        // 5) 15'ten büyük ve 22'den küçük sayılar
        var aralik = sayilar.Where(s => s > 15 && s < 22);
        Console.WriteLine("15 < sayı < 22: " + string.Join(", ", aralik));

        // 6) Sayıların kareleri (yeni liste)
        var kareler = sayilar.Select(s => s * s);
        Console.WriteLine("Sayıların Kareleri: " + string.Join(", ", kareler));
    }
}
