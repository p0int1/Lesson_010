using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
//Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 
//для  данного  урока.  Выведите  на  экран  значения  элементов  массива, который  вернул  расширяющий 
//метод GetArray(). 

namespace Task_4
{
    static class ExMethod
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] a = new T[list.Count];

            for (int i = 0; i < list.Count; i++)
                a[i] = list[i];

            return a;
        }
    }

    class MyList<T>
    {
        T[] elements; int length = 0;
        public int Count { get { return length; } }

        public void Add(T el)
        {
            Array.Resize(ref elements, length + 1);
            elements[elements.Length - 1] = el;
            length = elements.Length;
        }

        public T this[int index] { get { return elements[index]; } }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> animal = new MyList<string>();
            animal.Add("dog");
            animal.Add("cat");
            animal.Add("rat");

            var arr = animal.GetArray();

            foreach (var el in arr)
                Console.WriteLine(el);

            Console.WriteLine("Нажмите клавишу для выхода..");
            Console.ReadKey();
        }
    }
}
