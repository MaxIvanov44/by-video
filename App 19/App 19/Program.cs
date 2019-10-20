using System;

namespace App_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4];
            try
            {
                Console.WriteLine("Введите строку:  ");
                string message = Console.ReadLine();
             
                if (message.Length > 6)
                {
                    throw new Exception("Длина строки > 6 символов");
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Финал");
            }


            Console.ReadKey();
        }
    }
}
