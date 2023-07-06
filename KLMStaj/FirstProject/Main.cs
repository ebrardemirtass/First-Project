int modeNumber;
Console.WriteLine("Çalışma Modu Seçimi İçin");
GetValidNumber(out modeNumber);

switch (modeNumber)
{
    case 0:
        CustomAlgorithm();
        break;
    case 1:
        PrintStars();
        break;
    case 2:
        DivideByThree();
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

void CustomAlgorithm()
{
    int enteredNumber;
    int loopCount;

    GetValidNumber(out enteredNumber);
    GetValidNumber(out loopCount);

    for (int i = 0; i < loopCount; i++)
    {
        Console.WriteLine($"Girdiğiniz Sayı: {enteredNumber}");
    }
}

/// <summary>
/// This method should print star stairs
/// </summary>
void PrintStars()
{
    int starCount;
    Console.WriteLine("Yıldız Basamağı İçin");
    GetValidNumber(out starCount);

    for (int i = 0; i <= starCount; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write(" * ");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// This method should print multiples of three up to the entered number
/// </summary>
void DivideByThree()
{
    int limit;
    List<int> numbers = new List<int>();
    Console.WriteLine("Kaça kadar bölünecek ?");
    GetValidNumber(out limit);
    for (int i = 1; i <= limit; i++)
    {
        if (i % 3 == 0)
        {
            Console.WriteLine(i);
            numbers.Add(i);
        }
    }
    int count = numbers.Count();
    Console.WriteLine($"Girdiğiniz {limit} sayısına kadar 3 e bölünen toplam {count} sayı bulunmaktadır.");
}