using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Создайте  класс  MyList<T>.  Реализуйте  в  простейшем  приближении  возможность  использования  его 
//экземпляра  аналогично  экземпляру  класса  List<T>.  Минимально  требуемый  интерфейс 
//взаимодействия  с  экземпляром, должен  включать  метод  добавления  элемента, индексатор  для 
//получения  значения  элемента  по  указанному  индексу  и  свойство  только  для  чтения  для  получения 
//общего количества элементов.  

namespace Task_2
{
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
            Console.WriteLine($"Первый элемент: {animal[0]}\nВторой элемент: {animal[1]}");

            Console.WriteLine(new string('-', 30));

            MyList<int> number = new MyList<int>();
            number.Add(13);
            number.Add(14);
            Console.WriteLine($"Элемент под индексом 0: {number[0]}");
            Console.WriteLine($"Количество элементов в массиве: {number.Count}");

            Console.WriteLine("Нажмите клавишу для выхода..");
            Console.ReadKey();
        }
    }
}
