namespace UtilityProject
{
    internal class FileHelper
    {
        public string ReadLines(string filePath)
        {
            string? resultValue = null;
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                return fileContent;
            }
            else
            {
                resultValue += "Hatalı Dosya Yolu Girişi!";
                return resultValue;
            }
        }
    }
}