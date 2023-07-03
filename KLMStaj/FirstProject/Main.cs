Console.WriteLine("Sayı Giriniz:");
bool res;
int number;
string numberText= Console.ReadLine();
res = int.TryParse(numberText, out number);
if(res)
    Console.WriteLine("Girdiğiniz Sayi: " + number);
else
    Console.WriteLine("Sadece rakamlardan oluşan bir veri giriniz");
