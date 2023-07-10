namespace UtilityProject
{
    internal class FileHelper
    {
        public string ReadLines(string filePath)
        {
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                return fileContent;
            }
            else
            {
                Console.WriteLine("Hatalı Dosya Yolu Girişi!");
                return string.Empty;
            }
        }
    }
}