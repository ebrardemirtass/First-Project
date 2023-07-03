/*
Console.WriteLine("Hello C#");

Console.WriteLine("Sayı Giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Girdiğiniz Sayi: " + sayi);
*/
Console.WriteLine("Sayı Giriniz:");
bool sonuc;
int a;
string sayi= Console.ReadLine();
sonuc = int.TryParse(sayi, out a);
if(sonuc)
    Console.WriteLine("Girdiğiniz Sayi: " + sayi);
else
    Console.WriteLine("Sadece rakamlardan oluşan bir veri giriniz");
