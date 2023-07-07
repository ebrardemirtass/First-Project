using UtilityProject;

int modeNumber;

MainHelper mainHelper = new MainHelper();
AlgorithmHelper algorithmHelper = new AlgorithmHelper();

Console.WriteLine("Çalışma Modu Seçimi İçin");
mainHelper.GetValidNumber(out modeNumber);

switch (modeNumber)
{
    case 0:
        algorithmHelper.CustomAlgorithm();
        break;
    case 1:
        algorithmHelper.PrintStars();
        break;
    case 2:
        algorithmHelper.DivideByThree();
        break;
    default:
        Console.WriteLine("Henüz bu mod geliştirilmemiştir.");
        break;
}
