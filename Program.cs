using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название ОС (Mac, Ubuntu или Windows)");
            try
            {
                Client.Elector(Console.ReadLine());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Непредвиденная ошибка! Попробуйте еще раз.");
                Console.WriteLine(e.Message);
            }
        }
    }



}
