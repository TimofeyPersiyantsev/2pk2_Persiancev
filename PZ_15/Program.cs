namespace PZ_15
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите путь к каталогу: ");
            string path = Console.ReadLine();

            if (Directory.Exists(path))
            {
                string[] exeFiles = Directory.GetFiles(path, "*.exe");

                foreach (string file in exeFiles)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    Console.WriteLine($"Имя файла: {fileInfo.Name} | Дата создания: {fileInfo.CreationTime}");
                }
            }
            else
            {
                Console.WriteLine("Указанный каталог не существует.");
            }
        }
    }
}