using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.MotorinDA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            string result = "";

            string[] words = value.Split(' ');
            foreach (string word in words)
            {
                if (word.ToLower().Contains("нн"))
                {
                    string cleanWord = word.Trim('.', ',', '!', '?', ';', ':');
                    result += cleanWord + " ";
                }
            }
            return result.Trim();

        }
    }
}
