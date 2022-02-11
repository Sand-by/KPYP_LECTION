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
                Console.WriteLine($"Цикл n2 - Итерация N:{i} ");
                Thread.Sleep(2000);
            }
            #endregion
        }
        static void Main()
        {
            //Вариант 1
            Thread thread = new Thread(Method_1);//Создание потока
            thread.Name = "Поток 1";
            thread.Start();//Запуск потока
            thread.Priority = ThreadPriority.Highest;
            //Вариант 2
            new Thread(() =>
            {
                Thread.CurrentThread.Name = "Поток2";
                Thread.CurrentThread.IsBackground = true;

                Action action = () =>
                {
                    for (int i = 0; i < 10; i++)
                    {

                        Console.WriteLine($"{Thread.CurrentThread.Name} - Итерация N:{i} id-потока: " +
                            $"{Thread.CurrentThread.ManagedThreadId}");
                        Thread.Sleep(2000);
                    }
                };
                action();
            }).Start();
            Console.ReadKey();
        }
    }
}