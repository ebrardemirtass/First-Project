namespace UtilityProject
{
    internal class FileHelper
    {
        public string ReadLines(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);
            return fileContent;
        }
    }
}