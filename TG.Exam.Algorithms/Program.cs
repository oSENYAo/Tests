using System;

namespace TG.Exam.Algorithms
{
    class Program
    {
        // Это рекурсивный метод. Довольно затратна по памяти (в данном случае стэк), так же есть вероятность поймать Exception 
        //  1 Вариант: испольщовать try catch
        //  2 Вариант отказаться от модели рекурсивной функции
        static int Foo(int a, int b, int c)
        {
            if (1 < c)
                return Foo(b, b + a, c - 1);
            else
                return a;
        }

        // Данный метод сортирует элементы массива по возрастанию. Можно прибегнуть к уже готовому Array.Sort(), однако у данного метода тип возвр. значения void.
        // Поэтому придется объявить переменную.
        static int[] Bar(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
            return arr;
        }
        // Так же для "читаемости кода" следует правильно называть Методы. Хотя я мог это и не писать.
        static void Main(string[] args)
        {
            Console.WriteLine("Foo result: {0}", Foo(7, 2, 8));
            Console.WriteLine("Bar result: {0}", string.Join(", ", Bar(new[] { 7, 2, 8 })));

            Console.ReadKey();
        }
    }
}
