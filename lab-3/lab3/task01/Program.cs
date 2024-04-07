using ClassLibraryTask01;
namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            FileWriter fileWriter = new FileWriter();
            FileLogger fileLogger = new FileLogger(fileWriter, logger);
            fileLogger.Log("Лог-повідомлення");
            fileLogger.Error("Повідомлення про помилку");
            fileLogger.Warn("Попереджувальне повідомлення");
        }
    }
}