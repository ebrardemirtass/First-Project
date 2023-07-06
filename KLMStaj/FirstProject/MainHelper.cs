namespace FirstProject
{
    public class MainHelper
    {
        public void GetValidNumber(out int number)
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
    }
}
