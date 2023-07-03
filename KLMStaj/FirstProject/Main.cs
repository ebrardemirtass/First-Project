Console.WriteLine("Sayı Giriniz:");
bool res;
int number, number2;
string numberText = Console.ReadLine();
res = int.TryParse(numberText, out number);
if (!res)
     Console.WriteLine("Sadece rakamlardan oluşan bir veri giriniz");

Console.WriteLine("Loop Tekrar Sayısını Giriniz:");
string numberText2 = Console.ReadLine();

res = int.TryParse(numberText2, out number2);
if (!res)
    Console.WriteLine("Sadece rakamlardan oluşan bir veri giriniz");
int i = 0;
while( i < number2)
    {
    Console.WriteLine("Girdiğiniz Sayi: " + number);
    i++;
}
