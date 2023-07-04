int enteredNumber;
int loopCount;

GetValidNumber(out enteredNumber);
GetValidNumber(out loopCount);

for (int i = 0; i < loopCount; i++)
{
    Console.WriteLine($"Girdiğiniz Sayı: {enteredNumber}");
}

void GetValidNumber(out int number)
{
    string? enteredText;

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
    while (!enteredText.Equals("EXIT"));
}
