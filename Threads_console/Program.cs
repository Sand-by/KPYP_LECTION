using System.Threading;
namespace MyNamespace
{
    class Program
    {

        static void Method_1()
        {
            #region Задача 1
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} - Итерация N:{i} id-потока: " +
                    $"{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(5000);
            }
            #endregion
        }
        static void Method_2()
        {
            #region Задача 2
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} - Итерация N:{i} id-потока: " +
                    $"{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(2000);
            }
            #endregion
        }
        static void Main()
        {
            //Вариант 1
            Thread thread = new Thread(Method_1);//Создание потока
            //thread.Name = "Поток 1";
            thread.Start();//Запуск потока
            
            Thread thread2 = new Thread(Method_1);//Создание потока
            thread2.Name = "Поток 2";
            thread2.Start();//Запуск потока

            //Вариант 2
            new Thread(() =>
            {
                Thread.CurrentThread.Name = "Поток3";
                Thread.CurrentThread.IsBackground = true;

                Action action = () =>
                {
                    for (int i = 0; i < 10; i++)
                    {

                        Console.WriteLine($"{Thread.CurrentThread.Name} - Итерация N:{i} id-потока: " +
                            $"{Thread.CurrentThread.ManagedThreadId}");
                        Thread.Sleep(500);
                    }
                };
                action();
            }).Start();
            Console.ReadKey();
        }
    }
}