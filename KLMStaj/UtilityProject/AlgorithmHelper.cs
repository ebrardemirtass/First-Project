using ModelProject;

namespace UtilityProject
{
    public class AlgorithmHelper
    {
        MainHelper helper = new MainHelper();

        public void CustomAlgorithm()
        {
            int enteredNumber;
            int loopCount;

            helper.GetValidNumber(out enteredNumber, "Sayı Giriniz: ");
            helper.GetValidNumber(out loopCount, "Tekrar Etme Sayısı Giriniz: ");

            for (int i = 0; i < loopCount; i++)
            {
                Console.WriteLine($"Girdiğiniz Sayı: {enteredNumber}");
            }
        }

        /// <summary>
        /// This method should print star stairs
        /// </summary>
        public void PrintStars()
        {
            int starCount;

            helper.GetValidNumber(out starCount, "Yıldız Basamak Sayısı Giriniz: ");

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
        public void DivideByThree()
        {
            int limit;
            List<int> numbers = new List<int>();

            helper.GetValidNumber(out limit, "Kaça Kadar Bölünecek Sayı Giriniz: ");
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
        public void CreateCompany()
        {
            Console.WriteLine("Lütfen geçerli bir metin dosyasının yolunu girin:");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                FileHelper fileHelper = new FileHelper();
                string fileContent = fileHelper.ReadLines(filePath);
                string[] lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                DateTimeHelper dateTimeHelper = new DateTimeHelper();
                foreach (string line in lines)
                {
                    Company company = new Company();
                    company.Name = line.Trim();
                    company.Construction();
                    company.FoundationDate = dateTimeHelper.GenerateRandomDate();

                    Console.WriteLine($"{company.Id} - {company.Name} - {company.FoundationDate}");
                }
            }
            else { Console.WriteLine("Hatalı Dosya Yolu Girişi!"); }

        }
    }
}
