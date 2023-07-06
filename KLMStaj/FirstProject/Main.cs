using FirstProject;

int modeNumber;

MainHelper helper = new MainHelper();

Console.WriteLine("Çalışma Modu Seçimi İçin");
helper.GetValidNumber(out modeNumber);

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
void CustomAlgorithm()
{
    int enteredNumber;
    int loopCount;

    helper.GetValidNumber(out enteredNumber);
    helper.GetValidNumber(out loopCount);

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
    helper.GetValidNumber(out starCount);

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
    helper.GetValidNumber(out limit);
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