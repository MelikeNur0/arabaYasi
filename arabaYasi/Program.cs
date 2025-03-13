using System;

public class arabaYasi
{
    public static string DetermineCarCondition(int carAge)
    {
        if (carAge < 0 || carAge > 30)
            return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
        else if (carAge < 10)
            return "Arabanız yeni";
        else if (carAge < 20)
            return "Servise götürmeniz gerekebilir";
        else
            return "Arabanız hurdaya çıkabilir";
    }

    public static string DetermineCarConditionSwitch(int carAge)
    {
        return carAge switch
        {
            < 0 or > 30 => "Ya hiç üretilmedi ya da trafikten men edilmiştir",
            < 10 => "Arabanız yeni",
            < 20 => "Servise götürmeniz gerekebilir",
            _ => "Arabanız hurdaya çıkabilir",
        };
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Lütfen arabanızın yaşını giriniz: ");
        int carAge;
        if (int.TryParse(Console.ReadLine(), out carAge))
        {
            Console.WriteLine(arabaYasi.DetermineCarCondition(carAge));
            
        }
        else
        {
            Console.WriteLine("Geçerli bir yaş giriniz!");
        }
    }
}