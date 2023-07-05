int modeNumber;
Console.WriteLine("Çalışma Modu Seçimi İçin");
GetValidNumber(out modeNumber);

switch (modeNumber)
{
    case 0:
        Console.WriteLine("Normal Mod Seçilmiştir");

        int enteredNumber;
        int loopCount;

        GetValidNumber(out enteredNumber);
        GetValidNumber(out loopCount);

        for (int i = 0; i < loopCount; i++)
        {
            Console.WriteLine($"Girdiğiniz Sayı: {enteredNumber}");
        }

        break;
    case 1:
        PrintStars(default(int));
        break;
    default:
        Console.WriteLine("Henüz bu mod geliştirilmemiştir.");
        break;
}

void GetValidNumber(out int number)
{
    string? enteredText; // nullable

    // Firstly, trying to get valid number
    do
    {
        Console.Write("Sayı Giriniz : ");
        enteredText = Console.ReadLine();
        if (!int.TryParse(enteredText, out number))
        {
            Console.WriteLine("Sadece rakamlardan oluşan bir veri giriniz");
        }
        else
        {
            break;
        }
    }
    while (!enteredText.Equals("EXIT")); //string string karşılaştırması bütük küçük harf duyarlı
}


/// <summary>
/// This method should print star stairs
/// </summary>
void PrintStars(int starCount)
{

}