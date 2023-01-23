namespace Task_1._5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! \nКак Вас зовут?");
            string userName = Console.ReadLine();

            Console.WriteLine("\nСколько вам лет?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nКем вы работаете?");
            string userWork = Console.ReadLine();

            Console.WriteLine("\nЗравствуйте, {0}.", userName);
            Console.WriteLine("Вам, {0} лет.", userAge);
            Console.WriteLine("Вы прирождённый, {0}!", userWork);
        }
    }
}