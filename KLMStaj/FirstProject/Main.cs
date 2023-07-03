Console.WriteLine("Sayı Giriniz:");
bool sonuc;
int a;
string sayi= Console.ReadLine();
sonuc = int.TryParse(sayi, out a);
if(sonuc)
    Console.WriteLine("Girdiğiniz Sayi: " + a);
else
    Console.WriteLine("Sadece rakamlardan oluşan bir veri giriniz");
