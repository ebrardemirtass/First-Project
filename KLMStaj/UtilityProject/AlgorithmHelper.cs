namespace UtilityProject
{
    public class AlgorithmHelper
    {
        MainHelper helper = new MainHelper();

        public void CustomAlgorithm()
        {
            int enteredNumber;
            int loopCount;
            string numberReasonText = "Sayı Giriniz: ";
            helper.GetValidNumber(out enteredNumber, numberReasonText);
            numberReasonText = "Tekrar Etme Sayısı Giriniz: ";
            helper.GetValidNumber(out loopCount, numberReasonText);

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
            string numberReasonText = "Yıldız Basamak Sayısı Giriniz: ";
            helper.GetValidNumber(out starCount, numberReasonText);

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
            string numberReasonText = "Kaça Kadar Bölünecek Sayı Giriniz: ";
            helper.GetValidNumber(out limit,numberReasonText);
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
    }
}
