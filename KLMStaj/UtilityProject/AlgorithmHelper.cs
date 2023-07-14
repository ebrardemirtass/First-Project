using BusinessProject;

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
        public string? PrintStars(int starCount)
        {
            string? resultValue = null;

            for (int i = 0; i <= starCount; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    resultValue += " * ";
                }
                resultValue += Environment.NewLine;
            }

            return resultValue;
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
        public void CompanyMode()

        {
            Console.WriteLine("Lütfen geçerli bir metin dosyasının yolunu girin:");
            string filePath = Console.ReadLine();
            FileHelper fileHelper = new FileHelper();
            string fileContent = fileHelper.ReadLines(filePath);
            string[] lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in lines)
            {
                CompanyManager companyManager = new CompanyManager();
                companyManager.CreateCompany(line);
            }


        }
    }
}
