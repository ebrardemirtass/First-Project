bool res;
int number = 1;
int number2 = 1;
int i = 0;
string numberText = "";
string numberText2 = "";

while (!(numberText == "0" || numberText2 == "0" || numberText == "EXIT" || numberText2 == "EXIT"))
{
    Console.WriteLine("Sayı Giriniz:");
    numberText = Console.ReadLine();

    res = int.TryParse(numberText, out number);
    if (!res)
    {
        Console.WriteLine("Sadece rakamlardan oluşan bir veri giriniz");
    }

    Console.WriteLine("Loop Tekrar Sayısını Giriniz:");
    numberText2 = Console.ReadLine();

    res = int.TryParse(numberText2, out number2);
    if (!res)
    {
        Console.WriteLine("Sadece rakamlardan oluşan bir veri giriniz");
    }

    while (i < number2)
    {
        Console.WriteLine($"Girdiğiniz Sayı: {number}");
        i++;
    }
}
