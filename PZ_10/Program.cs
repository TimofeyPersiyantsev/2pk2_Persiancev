namespace PZ_10
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите два предложения:");
            Console.WriteLine("Предложение 1:");
            string sentence1 = Console.ReadLine();

            Console.WriteLine("Предложение 2:");
            string sentence2 = Console.ReadLine();

            string[] wordsSentence1 = sentence1.Split(new[] { ' ', ',', '.', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] wordsSentence2 = sentence2.Split(new[] { ' ', ',', '.', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> repeatedWords = new List<string>();

            foreach (string word1 in wordsSentence1)
            {
                foreach (string word2 in wordsSentence2)
                {
                    if (string.Equals(word1, word2, StringComparison.OrdinalIgnoreCase) && !repeatedWords.Contains(word1))
                    {
                        repeatedWords.Add(word1);
                    }
                }
            }

            Console.WriteLine("Повторяющиеся слова в обоих предложениях:");
            foreach (string word in repeatedWords)
            {
                Console.WriteLine(word);
            }
        }
}