using UtilityProject;

int modeNumber;

MainHelper mainHelper = new MainHelper();
AlgorithmHelper algorithmHelper = new AlgorithmHelper();

mainHelper.GetValidNumber(out modeNumber, " Lütfen Çalışma Modu Numarası Giriniz: ");

switch (modeNumber)
{
    case 0:
        mainHelper.GetValidNumber(out int enteredNumber, "Tekrarlanacak Sayıyı Giriniz: ");
        mainHelper.GetValidNumber(out int loopCount, "Tekrar Sayısı Giriniz: ");
        Console.Write(algorithmHelper.CustomAlgorithm(enteredNumber, loopCount));
        break;
    case 1:
        mainHelper.GetValidNumber(out int starCount, "Yıldız Basamak Sayısı Giriniz: ");
        Console.Write(algorithmHelper.PrintStars(starCount));
        break;
    case 2:
        mainHelper.GetValidNumber(out int limit, "Kaça kadar Bölünecek Sayı Giriniz: ");
        Console.Write(algorithmHelper.DivideByThree(limit));
        break;
    case 3:
        string filePath = Console.ReadLine();
        algorithmHelper.CompanyMode(filePath);
        break;
    default:
        Console.WriteLine("Henüz bu mod geliştirilmemiştir.");
        break;
}