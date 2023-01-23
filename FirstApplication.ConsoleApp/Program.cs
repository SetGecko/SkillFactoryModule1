namespace FirstApplication.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();

            Console.WriteLine("Сколько Вам лет");
            string age = Console.ReadLine();

            Greet(name, age);

            Console.WriteLine("Приятно было познакомиться.");
        }
        static void Greet(string name, string age)
        {
            Console.WriteLine("Здрвствуйте, {0}", name);
            Console.WriteLine("Мне сообщили, что Вам {0}", age);
        }
    }
}