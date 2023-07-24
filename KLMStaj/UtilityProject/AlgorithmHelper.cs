using ModelProject;
using BusinessProject;
namespace UtilityProject
{
    public class AlgorithmHelper
    {
        MainHelper helper = new MainHelper();

        public string? CustomAlgorithm(int enteredNumber, int loopCount)
        {
            string? resultValue = null;
            for (int i = 0; i < loopCount; i++)
            {
                resultValue += $"Girdiğiniz Sayı: {enteredNumber}";
                resultValue += Environment.NewLine;
            }
            return resultValue;
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
        public string? DivideByThree(int limit)
        {
            string? resultValue = null;

            List<int> numbers = new List<int>();

            for (int i = 1; i <= limit; i++)
            {
                if (i % 3 == 0)
                {
                    resultValue += i;
                    resultValue += Environment.NewLine;
                    numbers.Add(i);
                }
            }
            int count = numbers.Count();
            resultValue += $"Girdiğiniz {limit} sayısına kadar 3 e bölünen toplam {count} sayı bulunmaktadır.";
            return resultValue;
        }
        public string? CompanyMode(string filePath)
        {
            FileHelper fileHelper = new FileHelper();
            string fileContent = fileHelper.ReadLines(filePath);
            string[] lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            string? resultValue = null;
            foreach (string line in lines)
            {

                CompanyManager companyManager = new CompanyManager();
                Company company = companyManager.CreateCompany(line);

                resultValue += $"{company.Id} - {company.Name} - {company.FoundationDate}";
                resultValue += Environment.NewLine;

            }
            return resultValue;

        }
    }
}
